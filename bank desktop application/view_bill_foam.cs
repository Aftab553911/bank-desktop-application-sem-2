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
    public partial class view_bill_foam : Form
    {
        public view_bill_foam()
        {
            InitializeComponent();
        }

        private void view_bill_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin_foam S = new admin_foam();
            S.Show();
        }

        private void view_bill_foam_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            view_bill_GV.DataSource = BILL_DL.Bill_list;
        }
    }
}
