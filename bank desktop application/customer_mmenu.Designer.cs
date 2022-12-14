
namespace bank_desktop_application
{
    partial class customer_mmenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tran_history_btn = new System.Windows.Forms.Button();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.tran_history_btn);
            this.panel1.Controls.Add(this.check_balance_btn);
            this.panel1.Controls.Add(this.withdraw_btn);
            this.panel1.Controls.Add(this.deposit_btn);
            this.panel1.Location = new System.Drawing.Point(26, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 383);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(293, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(163, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "change password";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tran_history_btn
            // 
            this.tran_history_btn.Location = new System.Drawing.Point(402, 128);
            this.tran_history_btn.Name = "tran_history_btn";
            this.tran_history_btn.Size = new System.Drawing.Size(123, 23);
            this.tran_history_btn.TabIndex = 3;
            this.tran_history_btn.Text = "transection history";
            this.tran_history_btn.UseVisualStyleBackColor = true;
            this.tran_history_btn.Click += new System.EventHandler(this.tran_history_btn_Click);
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.Location = new System.Drawing.Point(154, 128);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(117, 23);
            this.check_balance_btn.TabIndex = 2;
            this.check_balance_btn.Text = "check balance";
            this.check_balance_btn.UseVisualStyleBackColor = true;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Location = new System.Drawing.Point(402, 58);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(123, 23);
            this.withdraw_btn.TabIndex = 1;
            this.withdraw_btn.Text = "withdraw fund";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // deposit_btn
            // 
            this.deposit_btn.Location = new System.Drawing.Point(154, 58);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(117, 23);
            this.deposit_btn.TabIndex = 0;
            this.deposit_btn.Text = "Deposit fund";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(142, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 65);
            this.panel3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "BANK MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::bank_desktop_application.Properties.Resources.photo_1541354329998_f4d9a9f9297f;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 121);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // customer_mmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(831, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "customer_mmenu";
            this.Text = "customer_mmenu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button tran_history_btn;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}