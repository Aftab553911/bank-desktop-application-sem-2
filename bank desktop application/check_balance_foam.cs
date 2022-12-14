using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bank_desktop_application.BL;
using bank_desktop_application.DL;
namespace bank_desktop_application
{
    public partial class check_balance_foam : Form
    {
        MUsers login_cus;
        public check_balance_foam(MUsers login_cus)
        {
            InitializeComponent();
            this.login_cus = login_cus;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   }

        private void total_balance_btn_Click(object sender, EventArgs e)
        {
            float total_price=0;
            foreach(user_details s in login_cus.User_related)
            {
                if (s.Transection_type == "deposit")
                {
                    total_price = total_price + s.Transection_money;
                }
                else
                {
                    total_price =  total_price-s.Transection_money;
                }

            }
            MessageBox.Show(total_price.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        }
    }
}
