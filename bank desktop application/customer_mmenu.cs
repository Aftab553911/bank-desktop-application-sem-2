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
    public partial class customer_mmenu : Form
    {
        MUsers login_cus;
        public customer_mmenu(MUsers login_cus)
        {
            InitializeComponent();
            this.login_cus=login_cus;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposit_form dep = new deposit_form(login_cus);
            dep.Show();

        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            with_draw_foam dep = new with_draw_foam(login_cus);
            dep.Show();
        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
             check_balance_foam dep = new check_balance_foam(login_cus);
            dep.Show();
        }

        private void tran_history_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            transection_history_foam dep = new transection_history_foam(login_cus);
            dep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dep = new Form2(login_cus);
            dep.Show();
           // storeaccountantIntoFile
        }

        private void button5_Click(object sender, EventArgs e)
        {

            change_password s = new change_password(login_cus);
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
          }
    }
}
