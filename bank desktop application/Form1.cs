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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sign_IN_btn_Click(object sender, EventArgs e)
        {
            MUsers new_user=null;
            Form2 f2 = new Form2( new_user);
            f2.Show();
            this.Hide();
        }

        private void signUP_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MUserDL.load_users();
            MUserDL.load_accountant();

        }
    }
}
