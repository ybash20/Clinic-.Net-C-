namespace Project_SE
{
    partial class employe
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
            this.emp_address = new System.Windows.Forms.ComboBox();
            this.emp_passw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addemp = new System.Windows.Forms.Button();
            this.ch_passw = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Back = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_address
            // 
            this.emp_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.emp_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.emp_address.Font = new System.Drawing.Font("Tahoma", 14F);
            this.emp_address.FormattingEnabled = true;
            this.emp_address.Items.AddRange(new object[] {
            "عدن",
            "لحج"});
            this.emp_address.Location = new System.Drawing.Point(81, 187);
            this.emp_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_address.Name = "emp_address";
            this.emp_address.Size = new System.Drawing.Size(172, 36);
            this.emp_address.TabIndex = 3;
            // 
            // emp_passw
            // 
            this.emp_passw.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_passw.Location = new System.Drawing.Point(81, 394);
            this.emp_passw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_passw.MaxLength = 100;
            this.emp_passw.Multiline = true;
            this.emp_passw.Name = "emp_passw";
            this.emp_passw.PasswordChar = '*';
            this.emp_passw.Size = new System.Drawing.Size(172, 36);
            this.emp_passw.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(293, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 38);
            this.label5.TabIndex = 39;
            this.label5.Text = "كلمة المرور";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emp_name
            // 
            this.emp_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.Location = new System.Drawing.Point(81, 113);
            this.emp_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_name.MaxLength = 100;
            this.emp_name.Multiline = true;
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(172, 36);
            this.emp_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(293, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "الاسم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emp_no
            // 
            this.emp_no.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_no.Location = new System.Drawing.Point(81, 33);
            this.emp_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_no.MaxLength = 100;
            this.emp_no.Multiline = true;
            this.emp_no.Name = "emp_no";
            this.emp_no.Size = new System.Drawing.Size(172, 36);
            this.emp_no.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(293, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 40;
            this.label4.Text = "رقم الموظف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emp_salary
            // 
            this.emp_salary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_salary.Location = new System.Drawing.Point(81, 254);
            this.emp_salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emp_salary.MaxLength = 100;
            this.emp_salary.Multiline = true;
            this.emp_salary.Name = "emp_salary";
            this.emp_salary.Size = new System.Drawing.Size(172, 36);
            this.emp_salary.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(293, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 38);
            this.label3.TabIndex = 37;
            this.label3.Text = "الراتب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(293, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 36;
            this.label2.Text = "العنوان";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_addemp
            // 
            this.btn_addemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addemp.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btn_addemp.ForeColor = System.Drawing.Color.Black;
            this.btn_addemp.Location = new System.Drawing.Point(167, 540);
            this.btn_addemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(152, 91);
            this.btn_addemp.TabIndex = 41;
            this.btn_addemp.Text = "اضافة";
            this.btn_addemp.UseVisualStyleBackColor = false;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // ch_passw
            // 
            this.ch_passw.AutoSize = true;
            this.ch_passw.Location = new System.Drawing.Point(81, 453);
            this.ch_passw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch_passw.Name = "ch_passw";
            this.ch_passw.Size = new System.Drawing.Size(129, 21);
            this.ch_passw.TabIndex = 42;
            this.ch_passw.Text = "Show Password";
            this.ch_passw.UseVisualStyleBackColor = true;
            this.ch_passw.CheckedChanged += new System.EventHandler(this.ch_passw_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 30);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setting
            // 
            this.setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Backup});
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(83, 26);
            this.setting.Text = "الاعدادات";
            // 
            // Back
            // 
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 26);
            this.Back.Text = "تراجع";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Backup
            // 
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(140, 26);
            this.Backup.Text = "Backup";
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 328);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(172, 36);
            this.textBox1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(293, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 38);
            this.label6.TabIndex = 45;
            this.label6.Text = "اسم المستخدم";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 644);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ch_passw);
            this.Controls.Add(this.btn_addemp);
            this.Controls.Add(this.emp_address);
            this.Controls.Add(this.emp_passw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emp_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emp_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "employe";
            this.Text = "employe";
            this.Load += new System.EventHandler(this.employe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox emp_address;
        private System.Windows.Forms.TextBox emp_passw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emp_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addemp;
        private System.Windows.Forms.CheckBox ch_passw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setting;
        private System.Windows.Forms.ToolStripMenuItem Back;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}