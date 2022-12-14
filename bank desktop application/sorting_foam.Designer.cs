
namespace bank_desktop_application
{
    partial class sorting_foam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.re_panel1 = new System.Windows.Forms.Panel();
            this.HEAP_s = new System.Windows.Forms.Button();
            this.radix_btn = new System.Windows.Forms.Button();
            this.COUNT_SORT_BTN = new System.Windows.Forms.Button();
            this.COUNTING__BTN = new System.Windows.Forms.Button();
            this.QUICK_BTN = new System.Windows.Forms.Button();
            this.MERGE_BTN = new System.Windows.Forms.Button();
            this.SELECTION_BTN = new System.Windows.Forms.Button();
            this.INSERTION_BTN = new System.Windows.Forms.Button();
            this.BUBBLE_BTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.re_panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // re_panel1
            // 
            this.re_panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.re_panel1.BackColor = System.Drawing.Color.LightGreen;
            this.re_panel1.Controls.Add(this.button1);
            this.re_panel1.Controls.Add(this.panel1);
            this.re_panel1.Controls.Add(this.HEAP_s);
            this.re_panel1.Controls.Add(this.radix_btn);
            this.re_panel1.Controls.Add(this.COUNT_SORT_BTN);
            this.re_panel1.Controls.Add(this.COUNTING__BTN);
            this.re_panel1.Controls.Add(this.QUICK_BTN);
            this.re_panel1.Controls.Add(this.MERGE_BTN);
            this.re_panel1.Controls.Add(this.SELECTION_BTN);
            this.re_panel1.Controls.Add(this.INSERTION_BTN);
            this.re_panel1.Controls.Add(this.BUBBLE_BTN);
            this.re_panel1.ForeColor = System.Drawing.Color.Brown;
            this.re_panel1.Location = new System.Drawing.Point(-1, 2);
            this.re_panel1.Name = "re_panel1";
            this.re_panel1.Size = new System.Drawing.Size(801, 445);
            this.re_panel1.TabIndex = 0;
            this.re_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.re_panel1_Paint);
            // 
            // HEAP_s
            // 
            this.HEAP_s.Location = new System.Drawing.Point(262, 339);
            this.HEAP_s.Name = "HEAP_s";
            this.HEAP_s.Size = new System.Drawing.Size(173, 34);
            this.HEAP_s.TabIndex = 18;
            this.HEAP_s.Text = "HEAP SORT";
            this.HEAP_s.UseVisualStyleBackColor = true;
            this.HEAP_s.Click += new System.EventHandler(this.HEAP_s_Click);
            // 
            // radix_btn
            // 
            this.radix_btn.Location = new System.Drawing.Point(431, 276);
            this.radix_btn.Name = "radix_btn";
            this.radix_btn.Size = new System.Drawing.Size(129, 29);
            this.radix_btn.TabIndex = 17;
            this.radix_btn.Text = "BUCKET SORT";
            this.radix_btn.UseVisualStyleBackColor = true;
            this.radix_btn.Click += new System.EventHandler(this.radix_btn_Click);
            // 
            // COUNT_SORT_BTN
            // 
            this.COUNT_SORT_BTN.Location = new System.Drawing.Point(130, 276);
            this.COUNT_SORT_BTN.Name = "COUNT_SORT_BTN";
            this.COUNT_SORT_BTN.Size = new System.Drawing.Size(135, 23);
            this.COUNT_SORT_BTN.TabIndex = 16;
            this.COUNT_SORT_BTN.Text = "RADIX SORT";
            this.COUNT_SORT_BTN.UseVisualStyleBackColor = true;
            this.COUNT_SORT_BTN.Click += new System.EventHandler(this.COUNT_SORT_BTN_Click);
            // 
            // COUNTING__BTN
            // 
            this.COUNTING__BTN.Location = new System.Drawing.Point(431, 218);
            this.COUNTING__BTN.Name = "COUNTING__BTN";
            this.COUNTING__BTN.Size = new System.Drawing.Size(130, 25);
            this.COUNTING__BTN.TabIndex = 15;
            this.COUNTING__BTN.Text = "COUNTING SORT";
            this.COUNTING__BTN.UseVisualStyleBackColor = true;
            this.COUNTING__BTN.Click += new System.EventHandler(this.HEAP_BTN_Click);
            // 
            // QUICK_BTN
            // 
            this.QUICK_BTN.Location = new System.Drawing.Point(132, 218);
            this.QUICK_BTN.Name = "QUICK_BTN";
            this.QUICK_BTN.Size = new System.Drawing.Size(133, 23);
            this.QUICK_BTN.TabIndex = 14;
            this.QUICK_BTN.Tag = "QUICK SORT";
            this.QUICK_BTN.Text = "QUICK SORT";
            this.QUICK_BTN.UseVisualStyleBackColor = true;
            this.QUICK_BTN.Click += new System.EventHandler(this.QUICK_BTN_Click);
            // 
            // MERGE_BTN
            // 
            this.MERGE_BTN.Location = new System.Drawing.Point(431, 147);
            this.MERGE_BTN.Name = "MERGE_BTN";
            this.MERGE_BTN.Size = new System.Drawing.Size(130, 23);
            this.MERGE_BTN.TabIndex = 13;
            this.MERGE_BTN.Text = "MERGE SORT";
            this.MERGE_BTN.UseVisualStyleBackColor = true;
            this.MERGE_BTN.Click += new System.EventHandler(this.MERGE_BTN_Click);
            // 
            // SELECTION_BTN
            // 
            this.SELECTION_BTN.Location = new System.Drawing.Point(132, 148);
            this.SELECTION_BTN.Name = "SELECTION_BTN";
            this.SELECTION_BTN.Size = new System.Drawing.Size(133, 23);
            this.SELECTION_BTN.TabIndex = 12;
            this.SELECTION_BTN.Text = "SELECTION SORT";
            this.SELECTION_BTN.UseVisualStyleBackColor = true;
            this.SELECTION_BTN.Click += new System.EventHandler(this.SELECTION_BTN_Click);
            // 
            // INSERTION_BTN
            // 
            this.INSERTION_BTN.Location = new System.Drawing.Point(430, 85);
            this.INSERTION_BTN.Name = "INSERTION_BTN";
            this.INSERTION_BTN.Size = new System.Drawing.Size(130, 23);
            this.INSERTION_BTN.TabIndex = 11;
            this.INSERTION_BTN.Text = "INSERTION_SORT";
            this.INSERTION_BTN.UseVisualStyleBackColor = true;
            this.INSERTION_BTN.Click += new System.EventHandler(this.INSERTION_BTN_Click);
            // 
            // BUBBLE_BTN
            // 
            this.BUBBLE_BTN.Location = new System.Drawing.Point(132, 84);
            this.BUBBLE_BTN.Name = "BUBBLE_BTN";
            this.BUBBLE_BTN.Size = new System.Drawing.Size(133, 23);
            this.BUBBLE_BTN.TabIndex = 10;
            this.BUBBLE_BTN.Text = "BUBBLE SORT";
            this.BUBBLE_BTN.UseVisualStyleBackColor = true;
            this.BUBBLE_BTN.Click += new System.EventHandler(this.BUBBLE_BTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(165, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 49);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sorting_foam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.re_panel1);
            this.Name = "sorting_foam";
            this.Text = "sorting_foam";
            this.Load += new System.EventHandler(this.sorting_foam_Load);
            this.re_panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel re_panel1;
        private System.Windows.Forms.Button COUNT_SORT_BTN;
        private System.Windows.Forms.Button COUNTING__BTN;
        private System.Windows.Forms.Button QUICK_BTN;
        private System.Windows.Forms.Button MERGE_BTN;
        private System.Windows.Forms.Button SELECTION_BTN;
        private System.Windows.Forms.Button INSERTION_BTN;
        private System.Windows.Forms.Button BUBBLE_BTN;
        private System.Windows.Forms.Button radix_btn;
        private System.Windows.Forms.Button HEAP_s;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}