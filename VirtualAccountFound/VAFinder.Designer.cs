namespace VirtualAccountFound
{
    partial class VAFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtVirualAccount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.dgvMerge = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblPayInfo = new DevComponents.DotNetBar.LabelX();
            this.dgvPayItem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "虛擬帳號";
            // 
            // txtVirualAccount
            // 
            this.txtVirualAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtVirualAccount.Border.Class = "TextBoxBorder";
            this.txtVirualAccount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVirualAccount.Location = new System.Drawing.Point(75, 11);
            this.txtVirualAccount.Name = "txtVirualAccount";
            this.txtVirualAccount.Size = new System.Drawing.Size(374, 25);
            this.txtVirualAccount.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(455, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(54, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查詢";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvMerge
            // 
            this.dgvMerge.AllowUserToAddRows = false;
            this.dgvMerge.AllowUserToDeleteRows = false;
            this.dgvMerge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMerge.BackgroundColor = System.Drawing.Color.White;
            this.dgvMerge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chMName,
            this.chMValue});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMerge.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMerge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMerge.Location = new System.Drawing.Point(12, 62);
            this.dgvMerge.Name = "dgvMerge";
            this.dgvMerge.ReadOnly = true;
            this.dgvMerge.RowHeadersVisible = false;
            this.dgvMerge.RowTemplate.Height = 24;
            this.dgvMerge.Size = new System.Drawing.Size(497, 200);
            this.dgvMerge.TabIndex = 3;
            // 
            // chMName
            // 
            this.chMName.HeaderText = "名稱";
            this.chMName.Name = "chMName";
            this.chMName.ReadOnly = true;
            this.chMName.Width = 150;
            // 
            // chMValue
            // 
            this.chMValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chMValue.HeaderText = "資料";
            this.chMValue.Name = "chMValue";
            this.chMValue.ReadOnly = true;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "合併欄位";
            // 
            // lblPayInfo
            // 
            this.lblPayInfo.AutoSize = true;
            this.lblPayInfo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPayInfo.BackgroundStyle.Class = "";
            this.lblPayInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPayInfo.Location = new System.Drawing.Point(12, 268);
            this.lblPayInfo.Name = "lblPayInfo";
            this.lblPayInfo.Size = new System.Drawing.Size(60, 21);
            this.lblPayInfo.TabIndex = 0;
            this.lblPayInfo.Text = "繳費資料";
            // 
            // dgvPayItem
            // 
            this.dgvPayItem.AllowUserToAddRows = false;
            this.dgvPayItem.AllowUserToDeleteRows = false;
            this.dgvPayItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPayItem.Location = new System.Drawing.Point(12, 295);
            this.dgvPayItem.Name = "dgvPayItem";
            this.dgvPayItem.ReadOnly = true;
            this.dgvPayItem.RowHeadersVisible = false;
            this.dgvPayItem.RowTemplate.Height = 24;
            this.dgvPayItem.Size = new System.Drawing.Size(497, 261);
            this.dgvPayItem.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名稱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "資料";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // VAFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 568);
            this.Controls.Add(this.dgvPayItem);
            this.Controls.Add(this.dgvMerge);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtVirualAccount);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblPayInfo);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Name = "VAFinder";
            this.Text = "依虛擬帳號反查";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVirualAccount;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMValue;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblPayInfo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPayItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}