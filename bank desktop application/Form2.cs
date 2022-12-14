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
    public partial class Form2 : Form
    {
        MUsers new_user;
        public Form2(MUsers new_user)
        {
            InitializeComponent();
           this.new_user = new_user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_name_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_box.Text;
            string roll = comboBox1.Text;
             new_user = new MUsers(username, password, roll);
          // string role = MuserDL.GETrole(signINuser);
           roll=MUserDL.check_user(new_user);
            if (roll == "admin")
            {
                admin_foam ad_foam = new admin_foam();
                ad_foam.Show();
                this.Hide();
            }
            if (roll == "customer")
            {
                //MUserDL.Current_user_list = null;
                //MUserDL.Current_user_list.Add(new_user);
                this.Hide();
                customer_mmenu s = new customer_mmenu(new_user);
                s.Show();
 }
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void role_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
