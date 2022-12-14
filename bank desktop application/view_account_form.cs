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
    public partial class view_account_form : Form
    {
        public view_account_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            view_accountant_grid.DataSource = Acc_holder_DL.Accounts_list;


        }

        private void view_accountant_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin_foam S = new admin_foam();
            S.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
