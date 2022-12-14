using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_desktop_application.BL
{
    class BillsBL
    {
        private string name;
        private string cnic;
        private float bill_amount;
        private float consumer_no;
        private string month;
        private string bill_type;

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public float Bill_amount { get => bill_amount; set => bill_amount = value; }
        public float Consumer_no { get => consumer_no; set => consumer_no = value; }
        public string Month { get => month; set => month = value; }
        public string Bill_type { get => bill_type; set => bill_type = value; }
        public BillsBL()
        {

        }
        public BillsBL(string name, string cnic, float bill_amount, float consumer_no, string month, string bill_type)
        {

            this.name = name;
            this.cnic = cnic;
            this.bill_amount = bill_amount;
            this.consumer_no = consumer_no;
            this.month = month;
            this.bill_type = bill_type;
        }
    }
}
