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
    public partial class add_user_foam : Form
    {
        string path = "C:\\Users\\Aftab\\Desktop\\bank desktop application\\bank desktop application\\bank desktop application\\bin\\Debug\\MUSERS.txt";
        public add_user_foam()
        {
            InitializeComponent();
        }

        private void add_user_foam_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username=add_name_box.Text; string password=add_pass_box.Text; string roll=comboBox1.Text;
            string cnic = textBox1.Text;
            bool flag = true;

            foreach(Account_holder aa in Acc_holder_DL.Accounts_list)
            {
                if (aa.Accounter_name == username && aa.Cnic_no == cnic)
                {
                    MUsers s = new MUsers(username, password, roll);

                    MUserDL.Muser_list.Add(s);
                    MessageBox.Show("successfully user added");
                    MUserDL.storeUserIntoFile(s, path);
                    flag = false;

                }
            }
            if (flag == true)
            {
                MessageBox.Show("you have to must create account first");
            }
  }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_foam dep = new admin_foam();
            dep.Show();
        }
    }
}
