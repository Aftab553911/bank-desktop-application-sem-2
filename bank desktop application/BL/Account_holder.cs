using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_desktop_application.BL
{
    class Account_holder
    {
        private int ID;     
            private string accounter_name;
            private string father_name;
            private string cnic_no;
       
            private string source_income;
            private string nationality;
            private string address;
            public Account_holder()
            {

            }
            public Account_holder(string accounter_name, string father_name, string cnic_no, string source_income, string nationality, string address,int ID)
            {
            
                this.accounter_name = accounter_name;
                this.father_name = father_name;
                this.cnic_no = cnic_no;
                this.nationality = nationality;
                this.address = address;
                this.source_income = source_income;
            this.ID = ID;

            }
            public string Accounter_name { get => accounter_name; set => accounter_name = value; }
            public string Father_name { get => father_name; set => father_name = value; }
            public string Address { get => address; set => address = value; }
            public string Nationality { get => nationality; set => nationality = value; }
            public string Source_income { get => source_income; set => source_income = value; }
            public string Cnic_no { get => cnic_no; set => cnic_no = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
    }

