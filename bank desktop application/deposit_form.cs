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
    public partial class deposit_form : Form
    {
        MUsers login_cus;
        public deposit_form(MUsers login_cus)
        {
            InitializeComponent();
            this.login_cus = login_cus;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {


            string transection_date = date_box.Text;
       string transection_type = comboBox1.Text;
        float transection_money=float.Parse(dep_name.Text);
            user_details s = new user_details(transection_money, transection_type, transection_date);
            login_cus.User_related.Add(s);
            MessageBox.Show("DEPOSIT SUCCESSFULLY");
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        }

        private void dep_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        }
    }
}
