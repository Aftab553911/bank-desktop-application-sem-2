using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_desktop_application.BL
{
   public class users_class
    {
        private string user_name;
        private string password;
        private string roll;
        private string cnic;
        private float total_money;
      

     

        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public string Roll { get => roll; set => roll = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public float Total_money { get => total_money; set => total_money = value; }
    
    }
    public class user_details
    {
        private string transection_date;
        private string transection_type;
        private float transection_money;
      // private float total_balance;
      public user_details(float transection_money,string transection_date, string transection_type)
        {
            this.transection_date = transection_date;
            this.transection_money = transection_money;
            this.transection_type = transection_type;
        }
        public string Transection_date { get => transection_date; set => transection_date = value; }
        public string Transection_type { get => transection_type; set => transection_type = value; }
        public float Transection_money { get => transection_money; set => transection_money = value; }
       // public float Total_balance { get => total_balance; set => total_balance = value; }
    }
}
