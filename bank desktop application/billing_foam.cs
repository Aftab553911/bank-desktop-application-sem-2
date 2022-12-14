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
    public partial class billing_foam : Form
    {
        public billing_foam()
        {
            InitializeComponent();
        }

        private void billing_foam_Load(object sender, EventArgs e)
        {
  }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string month; string bill_type; float consumer_no; float bill_amount; string cnic; string name;
            name = bill_name_box.Text;
            cnic = bill_cnic_box.Text;
            bill_type = bill_type_box.Text;
            consumer_no =float.Parse( bill_consumer_no_box.Text);
            bill_amount =float.Parse(bill_amount_box.Text);
            month = bill_month_box.Text;
            BillsBL s = new BillsBL(name,cnic,bill_amount, consumer_no, month, bill_type);
            BILL_DL.Bill_list.Add(s);
            MessageBox.Show("successfully bill added");
            this.Hide();
            admin_foam dep = new admin_foam();
            dep.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_foam dep = new admin_foam();
            dep.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
