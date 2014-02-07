using FISCA.Data;
using FISCA.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VirtualAccountFound
{
    public partial class VAFinder : BaseForm
    {
        const int BalanceAccountLength = 15;

        public VAFinder()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                QueryHelper query = new QueryHelper();
                string cmd = @"
                            select amount,paidamount,paydate,billxmldata from $paymenthistory.accountsreceivable 
                            where uid in 
	                            (
	                            select cast(refpaymenthistoryuid as bigint)
	                            from $paymenttransaction.accountsreceivable 
	                            where balanceaccount = '@BalanceAccount'
	                            )
                            ";

                string account = GetAccount();
                cmd = cmd.Replace("@BalanceAccount", account);

                DataTable dt = query.Select(cmd);

                dgvMerge.Rows.Clear();
                dgvPayItem.Rows.Clear();

                lblPayInfo.Text = "繳費資訊";
                if (dt.Rows.Count > 0)
                {
                    string amount = dt.Rows[0]["amount"] + "";
                    string paidamount = dt.Rows[0]["paidamount"] + "";
                    string paydate = dt.Rows[0]["paydate"] + "";
                    string billxml = dt.Rows[0]["billxmldata"] + "";

                    lblPayInfo.Text = string.Format("繳費資訊, 應繳：{0}, 已繳：{1}, 繳費日期：{2}", amount, paidamount, paydate);

                    XElement objxml = XElement.Parse(billxml);

                    foreach (XElement each in objxml.Element("Extensions").Elements("Extension"))
                    {
                        string[] fieldinfos = each.Attribute("Name").Value.Split(new string[] { "::" },
                            StringSplitOptions.RemoveEmptyEntries);

                        string type = fieldinfos[0].ToLower();
                        string name = string.Empty;
                        string value = each.Value;

                        if (fieldinfos.Length <= 1) //只有一個元素時都算是 MergeField。
                        {
                            type = "MergeField".ToLower();
                            name = fieldinfos[0];
                        }
                        else
                            name = fieldinfos[1];

                        if (type == "MergeField".ToLower())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgvMerge, name, value);
                            dgvMerge.Rows.Add(row);
                        }
                        else if (type == "PayItem".ToLower())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dgvMerge, name, value);
                            dgvPayItem.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("找不到資料。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetAccount()
        {
            string account = txtVirualAccount.Text;

            account = account.Substring(0, BalanceAccountLength);

            return account;
        }
    }
}
