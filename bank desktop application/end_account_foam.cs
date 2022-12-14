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
    public partial class end_account_foam : Form
    {
        public end_account_foam()
        {
            InitializeComponent();
        }

        private void end_account_foam_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string cnic = pass_box.Text;
            bool flag = true;
            foreach(Account_holder s in Acc_holder_DL.Accounts_list)
            {
                if (s.Accounter_name == name && s.Cnic_no == cnic)
                {
                    MessageBox.Show("account successfully deleted");
                    Acc_holder_DL.Accounts_list.Remove(s);
                    flag = false;

                }
            }
            if (flag == true)
            {
                MessageBox.Show("this account is not present");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_foam dep = new admin_foam();
            dep.Show();
        }
    }
}
