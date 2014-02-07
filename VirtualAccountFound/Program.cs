using FISCA;
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
        [MainMethod]
        public static void Main()
        {
            RibbonBarItem ribbon = MotherForm.RibbonBarItems["總務作業", "對帳"];
            ribbon["單筆查詢"].Click += delegate
            {
                new VAFinder().ShowDialog();
            };
        }
    }
}
