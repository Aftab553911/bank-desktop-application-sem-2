using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_desktop_application
{
    public partial class admin_foam : Form
    {
        public admin_foam()
        {
            InitializeComponent();
        }

        private void admin_foam_Load(object sender, EventArgs e)
        {

        }

        private void create_acc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            createaccountform fom = new createaccountform();
            fom.Show();
        }

        private void view_account_btn_Click(object sender, EventArgs e)
        {
            view_account_form s = new view_account_form();
            this.Hide();
            s.Show();
        }

        private void billin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            billing_foam s = new billing_foam();
            s.Show();
        }

        private void bill_hist_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_bill_foam s = new view_bill_foam();
            s.Show();
        }

        private void end_account_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            end_account_foam s = new end_account_foam();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();
        }

        private void SORTING_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            sorting_foam s = new sorting_foam();
            s.Show();
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_user_foam s = new add_user_foam();
            s.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
