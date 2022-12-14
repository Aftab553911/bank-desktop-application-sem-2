using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank_desktop_application.BL;
using bank_desktop_application.DL;

namespace bank_desktop_application.DL
{
    class BILL_DL
    {
        private static List<BillsBL> bill_list = new List<BillsBL>();

        internal static List<BillsBL> Bill_list { get => bill_list; set => bill_list = value; }
    }
}
