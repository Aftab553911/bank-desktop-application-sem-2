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
    public partial class change_password : Form
    {
        MUsers new_user;
        public change_password(MUsers new_user)
        {
            InitializeComponent();
            this.new_user = new_user;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pass = current_password_box.Text;

            if (new_user.Password == pass)
            {

                textBox1.Visible = true;
                textBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                string p2 = textBox1.Text;
                string p1 = textBox2.Text;

                if (p1 != "" || p2 != "")
                {
                    if (p1 == p2)
                    {
                        new_user.Password = p1;
                        MUserDL.storeUserIntoFileAGAIN();
                        this.Close();
                        customer_mmenu D = new customer_mmenu(new_user);

                        D.Show();

                    }
                    else
                    {

                        MessageBox.Show("passwords do not matched");
                        this.Close();
                        customer_mmenu D = new customer_mmenu(new_user);

                        D.Show();
                    }
                }

            }
        }

        private void current_password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            customer_mmenu D = new customer_mmenu(new_user);

            D.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
