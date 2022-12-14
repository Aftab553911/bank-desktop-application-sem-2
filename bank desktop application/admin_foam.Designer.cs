
namespace bank_desktop_application
{
    partial class admin_foam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.bill_hist_btn = new System.Windows.Forms.Button();
            this.billin_btn = new System.Windows.Forms.Button();
            this.end_account_btn = new System.Windows.Forms.Button();
            this.SORTING_BTN = new System.Windows.Forms.Button();
            this.view_account_btn = new System.Windows.Forms.Button();
            this.create_acc_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.add_user_btn);
            this.panel2.Controls.Add(this.bill_hist_btn);
            this.panel2.Controls.Add(this.billin_btn);
            this.panel2.Controls.Add(this.end_account_btn);
            this.panel2.Controls.Add(this.SORTING_BTN);
            this.panel2.Controls.Add(this.view_account_btn);
            this.panel2.Controls.Add(this.create_acc_btn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 448);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(147, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 73);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK MANAGEMENT SYSTEM";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Coral;
            this.button6.Location = new System.Drawing.Point(373, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "BACK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.ForeColor = System.Drawing.Color.Coral;
            this.add_user_btn.Location = new System.Drawing.Point(308, 311);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(190, 23);
            this.add_user_btn.TabIndex = 6;
            this.add_user_btn.Text = "add user";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // bill_hist_btn
            // 
            this.bill_hist_btn.ForeColor = System.Drawing.Color.Coral;
            this.bill_hist_btn.Location = new System.Drawing.Point(504, 237);
            this.bill_hist_btn.Name = "bill_hist_btn";
            this.bill_hist_btn.Size = new System.Drawing.Size(185, 23);
            this.bill_hist_btn.TabIndex = 5;
            this.bill_hist_btn.Text = "bill  history";
            this.bill_hist_btn.UseVisualStyleBackColor = true;
            this.bill_hist_btn.Click += new System.EventHandler(this.bill_hist_btn_Click);
            // 
            // billin_btn
            // 
            this.billin_btn.ForeColor = System.Drawing.Color.Coral;
            this.billin_btn.Location = new System.Drawing.Point(155, 237);
            this.billin_btn.Name = "billin_btn";
            this.billin_btn.Size = new System.Drawing.Size(137, 23);
            this.billin_btn.TabIndex = 4;
            this.billin_btn.Text = "billing";
            this.billin_btn.UseVisualStyleBackColor = true;
            this.billin_btn.Click += new System.EventHandler(this.billin_btn_Click);
            // 
            // end_account_btn
            // 
            this.end_account_btn.ForeColor = System.Drawing.Color.Coral;
            this.end_account_btn.Location = new System.Drawing.Point(504, 157);
            this.end_account_btn.Name = "end_account_btn";
            this.end_account_btn.Size = new System.Drawing.Size(185, 23);
            this.end_account_btn.TabIndex = 3;
            this.end_account_btn.Text = "end account";
            this.end_account_btn.UseVisualStyleBackColor = true;
            this.end_account_btn.Click += new System.EventHandler(this.end_account_btn_Click);
            // 
            // SORTING_BTN
            // 
            this.SORTING_BTN.ForeColor = System.Drawing.Color.Coral;
            this.SORTING_BTN.Location = new System.Drawing.Point(155, 157);
            this.SORTING_BTN.Name = "SORTING_BTN";
            this.SORTING_BTN.Size = new System.Drawing.Size(137, 23);
            this.SORTING_BTN.TabIndex = 2;
            this.SORTING_BTN.Text = "sorting";
            this.SORTING_BTN.UseVisualStyleBackColor = true;
            this.SORTING_BTN.Click += new System.EventHandler(this.SORTING_BTN_Click);
            // 
            // view_account_btn
            // 
            this.view_account_btn.ForeColor = System.Drawing.Color.Coral;
            this.view_account_btn.Location = new System.Drawing.Point(504, 87);
            this.view_account_btn.Name = "view_account_btn";
            this.view_account_btn.Size = new System.Drawing.Size(185, 23);
            this.view_account_btn.TabIndex = 1;
            this.view_account_btn.Text = "view accounts";
            this.view_account_btn.UseVisualStyleBackColor = true;
            this.view_account_btn.Click += new System.EventHandler(this.view_account_btn_Click);
            // 
            // create_acc_btn
            // 
            this.create_acc_btn.ForeColor = System.Drawing.Color.Coral;
            this.create_acc_btn.Location = new System.Drawing.Point(155, 88);
            this.create_acc_btn.Name = "create_acc_btn";
            this.create_acc_btn.Size = new System.Drawing.Size(137, 23);
            this.create_acc_btn.TabIndex = 0;
            this.create_acc_btn.Text = "create account";
            this.create_acc_btn.UseVisualStyleBackColor = true;
            this.create_acc_btn.Click += new System.EventHandler(this.create_acc_btn_Click);
            // 
            // admin_foam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "admin_foam";
            this.Text = "admin_foam";
            this.Load += new System.EventHandler(this.admin_foam_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button view_account_btn;
        private System.Windows.Forms.Button create_acc_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button bill_hist_btn;
        private System.Windows.Forms.Button billin_btn;
        private System.Windows.Forms.Button end_account_btn;
        private System.Windows.Forms.Button SORTING_BTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}