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
    public partial class del_foam : Form
    {
        public del_foam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string pass = pass_box.Text;
          /*  foreach(Account_holder s in )
            {
                if(name==s.)
            }*/
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
