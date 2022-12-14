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
    public partial class with_draw_foam : Form
    {
        MUsers login_cus;
        public with_draw_foam(MUsers login_cus)
        {
            InitializeComponent();
            this.login_cus = login_cus;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            string transection_date = date_box.Text;
            string transection_type = comboBox1.Text;
            float transection_money = float.Parse(with_draw_money_box.Text);
            user_details s = new user_details(transection_money, transection_type, transection_date);
            login_cus.User_related.Add(s);
            MessageBox.Show("SUCCESSFULLY WITHDRAW");
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        



    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        }
    }
}
