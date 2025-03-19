namespace Project_SE
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.groub_text = new System.Windows.Forms.GroupBox();
            this.txt_norego = new System.Windows.Forms.ComboBox();
            this.btn_add_per = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txt_priserego = new System.Windows.Forms.TextBox();
            this.comb_type_name = new System.Windows.Forms.ComboBox();
            this.comb_per_name = new System.Windows.Forms.ComboBox();
            this.comb_dr_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rid_rego = new System.Windows.Forms.RadioButton();
            this.rid_test = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groub_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(379, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم التسجيل";
            // 
            // groub_text
            // 
            this.groub_text.BackgroundImage = global::Project_SE.Properties.Resources._7616ce55552d7a8548c7ed5b53aae6f0;
            this.groub_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groub_text.Controls.Add(this.btn_back);
            this.groub_text.Controls.Add(this.btn_close);
            this.groub_text.Controls.Add(this.txt_norego);
            this.groub_text.Controls.Add(this.btn_add_per);
            this.groub_text.Controls.Add(this.btnadd);
            this.groub_text.Controls.Add(this.date);
            this.groub_text.Controls.Add(this.txt_priserego);
            this.groub_text.Controls.Add(this.comb_type_name);
            this.groub_text.Controls.Add(this.comb_per_name);
            this.groub_text.Controls.Add(this.comb_dr_name);
            this.groub_text.Controls.Add(this.label6);
            this.groub_text.Controls.Add(this.label5);
            this.groub_text.Controls.Add(this.label4);
            this.groub_text.Controls.Add(this.label3);
            this.groub_text.Controls.Add(this.label2);
            this.groub_text.Controls.Add(this.label1);
            this.groub_text.Font = new System.Drawing.Font("Arial", 12F);
            this.groub_text.ForeColor = System.Drawing.Color.Blue;
            this.groub_text.Location = new System.Drawing.Point(16, 123);
            this.groub_text.Margin = new System.Windows.Forms.Padding(4);
            this.groub_text.Name = "groub_text";
            this.groub_text.Padding = new System.Windows.Forms.Padding(4);
            this.groub_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groub_text.Size = new System.Drawing.Size(553, 615);
            this.groub_text.TabIndex = 1;
            this.groub_text.TabStop = false;
            this.groub_text.Text = "التسجيل";
            this.groub_text.Enter += new System.EventHandler(this.groub_text_Enter);
            // 
            // txt_norego
            // 
            this.txt_norego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txt_norego.Enabled = false;
            this.txt_norego.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_norego.FormattingEnabled = true;
            this.txt_norego.Location = new System.Drawing.Point(149, 97);
            this.txt_norego.Margin = new System.Windows.Forms.Padding(4);
            this.txt_norego.Name = "txt_norego";
            this.txt_norego.Size = new System.Drawing.Size(199, 31);
            this.txt_norego.TabIndex = 14;
            // 
            // btn_add_per
            // 
            this.btn_add_per.Font = new System.Drawing.Font("Arabic Typesetting", 20F);
            this.btn_add_per.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_add_per.Location = new System.Drawing.Point(149, 553);
            this.btn_add_per.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_per.Name = "btn_add_per";
            this.btn_add_per.Size = new System.Drawing.Size(207, 43);
            this.btn_add_per.TabIndex = 13;
            this.btn_add_per.Text = "اضافة مريض جديد";
            this.btn_add_per.UseVisualStyleBackColor = true;
            this.btn_add_per.Click += new System.EventHandler(this.btn_add_per_Click);
            this.btn_add_per.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_add_per_MouseClick);
            this.btn_add_per.MouseLeave += new System.EventHandler(this.btn_add_per_MouseLeave);
            this.btn_add_per.MouseHover += new System.EventHandler(this.btn_add_per_MouseHover);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Arabic Typesetting", 20F);
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnadd.Location = new System.Drawing.Point(149, 495);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(207, 43);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "اضافة السجل";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnadd_MouseClick);
            this.btnadd.MouseLeave += new System.EventHandler(this.btnadd_MouseLeave);
            this.btnadd.MouseHover += new System.EventHandler(this.btnadd_MouseHover);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Arial", 12F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(149, 431);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(199, 30);
            this.date.TabIndex = 11;
            // 
            // txt_priserego
            // 
            this.txt_priserego.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_priserego.Location = new System.Drawing.Point(149, 363);
            this.txt_priserego.Margin = new System.Windows.Forms.Padding(4);
            this.txt_priserego.Name = "txt_priserego";
            this.txt_priserego.Size = new System.Drawing.Size(199, 30);
            this.txt_priserego.TabIndex = 10;
            // 
            // comb_type_name
            // 
            this.comb_type_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_type_name.Font = new System.Drawing.Font("Arial", 12F);
            this.comb_type_name.FormattingEnabled = true;
            this.comb_type_name.Location = new System.Drawing.Point(149, 298);
            this.comb_type_name.Margin = new System.Windows.Forms.Padding(4);
            this.comb_type_name.Name = "comb_type_name";
            this.comb_type_name.Size = new System.Drawing.Size(199, 31);
            this.comb_type_name.TabIndex = 9;
            this.comb_type_name.SelectedIndexChanged += new System.EventHandler(this.comb_type_name_SelectedIndexChanged);
            // 
            // comb_per_name
            // 
            this.comb_per_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_per_name.Font = new System.Drawing.Font("Arial", 12F);
            this.comb_per_name.FormattingEnabled = true;
            this.comb_per_name.Location = new System.Drawing.Point(149, 234);
            this.comb_per_name.Margin = new System.Windows.Forms.Padding(4);
            this.comb_per_name.Name = "comb_per_name";
            this.comb_per_name.Size = new System.Drawing.Size(199, 31);
            this.comb_per_name.TabIndex = 8;
            // 
            // comb_dr_name
            // 
            this.comb_dr_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_dr_name.Font = new System.Drawing.Font("Arial", 12F);
            this.comb_dr_name.FormattingEnabled = true;
            this.comb_dr_name.Location = new System.Drawing.Point(149, 165);
            this.comb_dr_name.Margin = new System.Windows.Forms.Padding(4);
            this.comb_dr_name.Name = "comb_dr_name";
            this.comb_dr_name.Size = new System.Drawing.Size(199, 31);
            this.comb_dr_name.TabIndex = 7;
            this.comb_dr_name.SelectedIndexChanged += new System.EventHandler(this.comb_dr_name_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 19F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(379, 431);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "تاريخ التسجيل";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 19F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(379, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "سعر التسجيل";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 19F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(379, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(140, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "نوع الفترة";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 19F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(379, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المريض";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 19F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(379, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الدكتور";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arabic Typesetting", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(599, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "التسجيل و الفحص";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rid_rego
            // 
            this.rid_rego.AutoSize = true;
            this.rid_rego.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rid_rego.Checked = true;
            this.rid_rego.Font = new System.Drawing.Font("Arabic Typesetting", 20F);
            this.rid_rego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rid_rego.Location = new System.Drawing.Point(327, 73);
            this.rid_rego.Margin = new System.Windows.Forms.Padding(4);
            this.rid_rego.Name = "rid_rego";
            this.rid_rego.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rid_rego.Size = new System.Drawing.Size(140, 44);
            this.rid_rego.TabIndex = 3;
            this.rid_rego.TabStop = true;
            this.rid_rego.Text = "تسجيل جديد";
            this.rid_rego.UseVisualStyleBackColor = false;
            this.rid_rego.CheckedChanged += new System.EventHandler(this.rid_rego_CheckedChanged);
            // 
            // rid_test
            // 
            this.rid_test.AutoSize = true;
            this.rid_test.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rid_test.Font = new System.Drawing.Font("Arabic Typesetting", 20F);
            this.rid_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rid_test.Location = new System.Drawing.Point(113, 73);
            this.rid_test.Margin = new System.Windows.Forms.Padding(4);
            this.rid_test.Name = "rid_test";
            this.rid_test.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rid_test.Size = new System.Drawing.Size(76, 44);
            this.rid_test.TabIndex = 4;
            this.rid_test.Text = "فحص";
            this.rid_test.UseVisualStyleBackColor = false;
            this.rid_test.CheckedChanged += new System.EventHandler(this.rid_test_CheckedChanged);
            // 
            // btn_close
            // 
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(422, 495);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 43);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(422, 550);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 43);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "رجوع";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(599, 740);
            this.ControlBox = false;
            this.Controls.Add(this.rid_test);
            this.Controls.Add(this.rid_rego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groub_text);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التسجيل";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.Shown += new System.EventHandler(this.Registration_Shown);
            this.groub_text.ResumeLayout(false);
            this.groub_text.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txt_priserego;
        private System.Windows.Forms.ComboBox comb_type_name;
        private System.Windows.Forms.ComboBox comb_per_name;
        private System.Windows.Forms.ComboBox comb_dr_name;
        private System.Windows.Forms.GroupBox groub_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rid_rego;
        private System.Windows.Forms.RadioButton rid_test;
        private System.Windows.Forms.Button btn_add_per;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox txt_norego;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
    }
}