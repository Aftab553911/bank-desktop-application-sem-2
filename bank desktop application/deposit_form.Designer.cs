
namespace bank_desktop_application
{
    partial class deposit_form
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tran_type = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.dep_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tran_type);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.date_box);
            this.panel1.Controls.Add(this.password_box);
            this.panel1.Controls.Add(this.dep_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "deposit"});
            this.comboBox1.Location = new System.Drawing.Point(323, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // tran_type
            // 
            this.tran_type.AutoSize = true;
            this.tran_type.Location = new System.Drawing.Point(167, 183);
            this.tran_type.Name = "tran_type";
            this.tran_type.Size = new System.Drawing.Size(82, 13);
            this.tran_type.TabIndex = 8;
            this.tran_type.Text = "transection type";
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(443, 298);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_box
            // 
            this.date_box.Location = new System.Drawing.Point(323, 233);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(153, 20);
            this.date_box.TabIndex = 5;
            this.date_box.TextChanged += new System.EventHandler(this.date_box_TextChanged);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(323, 135);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(153, 20);
            this.password_box.TabIndex = 4;
            this.password_box.TextChanged += new System.EventHandler(this.password_box_TextChanged);
            // 
            // dep_name
            // 
            this.dep_name.Location = new System.Drawing.Point(323, 81);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(153, 20);
            this.dep_name.TabIndex = 3;
            this.dep_name.TextChanged += new System.EventHandler(this.dep_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "money ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(195, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 65);
            this.panel3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "BANK MANAGEMENT SYSTEM";
            // 
            // deposit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(862, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "deposit_form";
            this.Text = "deposit_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox dep_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label tran_type;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
    }
}