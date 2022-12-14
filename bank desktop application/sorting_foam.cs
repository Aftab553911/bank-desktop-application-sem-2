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
    public partial class sorting_foam : Form
    {
        public sorting_foam()
        {
            InitializeComponent();
        }

        private void sorting_foam_Load(object sender, EventArgs e)
        {

        }

        private void bubble_sort_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUBBLE_BTN_Click(object sender, EventArgs e)
        {
            int count = 1;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void re_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MERGE_BTN_Click(object sender, EventArgs e)
        {
            int count = 4;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void INSERTION_BTN_Click(object sender, EventArgs e)
        {
            int count = 2;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();

        }

        private void QUICK_BTN_Click(object sender, EventArgs e)
        {
            int count = 5;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void HEAP_BTN_Click(object sender, EventArgs e)
        {
            int count = 6;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void COUNT_SORT_BTN_Click(object sender, EventArgs e)
        {
            int count = 7;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void SELECTION_BTN_Click(object sender, EventArgs e)
        {
            int count = 3;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void radix_btn_Click(object sender, EventArgs e)
        {
            int count = 8;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void heap_ag_sorting_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void HEAP_s_Click(object sender, EventArgs e)
        {
            int count = 9;
            sorted_data_view s = new sorted_data_view(count);
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_foam s = new admin_foam();
            s.Show();

        }
    }
}
