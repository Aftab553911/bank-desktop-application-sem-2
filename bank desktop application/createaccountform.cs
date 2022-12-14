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
    public partial class createaccountform : Form
    {
        string path = "C:\\Users\\Aftab\\Desktop\\bank desktop application\\bank desktop application\\bank desktop application\\bin\\Debug\\ACCOUNT_HOLDER.txt";
        public createaccountform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nationality=nationality_box.Text;
            string address=address_box.Text;
            string source_income=income_sorce_box.Text;
            string cnic_no=cnic_box.Text;
            string father_name=fathe_name_box.Text;
            string accounter_name=name_box.Text;
            int ID1 = int.Parse(id_text.Text);
            Account_holder A = new Account_holder(accounter_name, father_name, cnic_no, source_income, nationality, address,ID1);
            Acc_holder_DL.Accounts_list.Add(A);

            MessageBox.Show("successfully add customer");
            Acc_holder_DL.storeaccountantIntoFile(A, path);
            this.Hide();
            admin_foam s = new admin_foam();
            s.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_foam s = new admin_foam();
            s.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
