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
    public partial class transection_history_foam : Form
    {
        MUsers login_cus;
        public transection_history_foam(MUsers login_cus)
        {
            InitializeComponent();
            this.login_cus = login_cus;
        }
         private void user_tran_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transection_history_foam_Load(object sender, EventArgs e)
        {
            user_tran_GV.DataSource = login_cus.User_related;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            customer_mmenu D = new customer_mmenu(login_cus);

            D.Show();
        }
    }
}
