using FISCA;
using FISCA.Permission;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAccountFound
{
    public static class Program
    {
        const string Code = "VirtualAccountFound.VAFinder";

        [MainMethod]
        public static void Main()
        {
            RibbonBarItem ribbon = MotherForm.RibbonBarItems["總務作業", "對帳"];

            ribbon["單筆查詢"].Enable = UserAcl.Current[Code].Executable;
            ribbon["單筆查詢"].Click += delegate
            {
                new VAFinder().ShowDialog();
            };

            RoleAclSource.Instance["總務作業"]["對帳"].Add(new RibbonFeature(Code, "單筆查詢"));
        }
    }
}
