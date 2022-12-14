
namespace bank_desktop_application
{
    partial class transection_history_foam
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
            this.user_tran_GV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_tran_GV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.user_tran_GV);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 520);
            this.panel1.TabIndex = 0;
            // 
            // user_tran_GV
            // 
            this.user_tran_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_tran_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.user_tran_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_tran_GV.Location = new System.Drawing.Point(9, 114);
            this.user_tran_GV.Name = "user_tran_GV";
            this.user_tran_GV.Size = new System.Drawing.Size(773, 375);
            this.user_tran_GV.TabIndex = 0;
            this.user_tran_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_tran_GV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(184, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 65);
            this.panel3.TabIndex = 19;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transection_history_foam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "transection_history_foam";
            this.Text = "transection_history_foam";
            this.Load += new System.EventHandler(this.transection_history_foam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_tran_GV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView user_tran_GV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}