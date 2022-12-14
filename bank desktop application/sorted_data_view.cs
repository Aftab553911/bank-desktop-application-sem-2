using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using bank_desktop_application.BL;
using bank_desktop_application.DL;

namespace bank_desktop_application
{
    public partial class sorted_data_view : Form
    {
        int count = 0;
        

        public sorted_data_view(int num)
        {
            InitializeComponent();
            count = num;
        }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (count == 1)
            {
                /*   Acc_holder_DL.Temp_list = Acc_holder_DL.Accounts_list;
                   Acc_holder_DL.Temp_list =*/
                var watch = System.Diagnostics.Stopwatch.StartNew();

                dataGridView1.DataSource = Acc_holder_DL.BUBBLE_SORT(Acc_holder_DL.Accounts_list);
                /*  dataGridView1.DataSource = Acc_holder_DL.Temp_list;*/
               
                watch.Stop();
                TIME_ANS.Text ="bubble sort    "+ $"Execution Time: {watch.ElapsedMilliseconds} ms";

            }
            if (count == 2)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                dataGridView1.DataSource = Acc_holder_DL.INSERTION_SORT();
                watch.Stop();
                TIME_ANS.Text = "insertion sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";
                /*  Acc_holder_DL.Temp_list = Acc_holder_DL.Accounts_list;

                  Acc_holder_DL.Temp_list =Acc_holder_DL.INSERTION_SORT(Acc_holder_DL.Temp_list);
                  dataGridView1.DataSource = Acc_holder_DL.Temp_list;*/
            }
            if (count == 3)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                dataGridView1.DataSource = Acc_holder_DL.selection_sort();
                watch.Stop();
                TIME_ANS.Text = "selection sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";

                /*   Acc_holder_DL.Temp_list = Acc_holder_DL.Accounts_list;

                   Acc_holder_DL.Temp_list=Acc_holder_DL.selection_sort(Acc_holder_DL.Temp_list);
                   dataGridView1.DataSource = Acc_holder_DL.Temp_list;*/
            }
            if (count == 4)
            {
                 

                int start = 0;
                int end = Acc_holder_DL.Accounts_list.Count - 1;
                List<Account_holder> temp = new List<Account_holder>();
                      temp= Acc_holder_DL.Accounts_list;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Acc_holder_DL.merge_Sort(temp, start, end);
                dataGridView1.DataSource = temp;
                watch.Stop();
                TIME_ANS.Text = "merge sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";


            }
            if (count == 5)
            {

                int start = 0;
                int end = Acc_holder_DL.Accounts_list.Count - 1;
                List<Account_holder> temp_list = new List<Account_holder>();
                temp_list = Acc_holder_DL.Accounts_list;
                var watch = System.Diagnostics.Stopwatch.StartNew();

                Acc_holder_DL.quickSort(temp_list, start, end);
                dataGridView1.DataSource = temp_list;
                watch.Stop();
                TIME_ANS.Text = "quick sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";

            }
            if (count == 6)
            {
                List<Account_holder> temp_list = new List<Account_holder>();
                temp_list = Acc_holder_DL.Accounts_list;
                var watch = System.Diagnostics.Stopwatch.StartNew();

                temp_list = Acc_holder_DL.countingSorted(temp_list);
                dataGridView1.DataSource = temp_list;
                watch.Stop();
                TIME_ANS.Text = "counting sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";

            }
            if (count == 7)
            {
                List<Account_holder> temp_list = new List<Account_holder>();
                temp_list = Acc_holder_DL.Accounts_list;
                var watch = System.Diagnostics.Stopwatch.StartNew();

                Acc_holder_DL.radixSort(temp_list);
                dataGridView1.DataSource = temp_list;
                watch.Stop();
                TIME_ANS.Text = "radix  sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";
            }
            if (count == 8)
            {
                /*  List<Account_holder> temp_list = new List<Account_holder>();
                  temp_list = Acc_holder_DL.Accounts_list;*/
                var watch = System.Diagnostics.Stopwatch.StartNew();

                dataGridView1.DataSource = Acc_holder_DL.bucket_sort();
                watch.Stop();
                TIME_ANS.Text = "bucket sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";


            }  if (count == 9)
            {
                List<Account_holder> temp_list = new List<Account_holder>();
                temp_list = Acc_holder_DL.Accounts_list;
                var watch = System.Diagnostics.Stopwatch.StartNew();

                Acc_holder_DL.heapSort(temp_list,temp_list.Count);
                dataGridView1.DataSource = temp_list;
                watch.Stop();
                TIME_ANS.Text = "heap sort    " + $"Execution Time: {watch.ElapsedMilliseconds} ms";
               
            }

        }

        /*}*/

        private void sorted_back_Click(object sender, EventArgs e)
        {
            this.Close();
            admin_foam S = new admin_foam();
            S.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TIME_ANS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
