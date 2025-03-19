namespace Project_SE
{
    partial class Reg
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
            this.lab_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_id_reg = new System.Windows.Forms.Label();
            this.Group_Per = new System.Windows.Forms.GroupBox();
            this.lab_id_p = new System.Windows.Forms.Label();
            this.comb_address = new System.Windows.Forms.ComboBox();
            this.comb_gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_name_p = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Group_Reg = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reg_price = new System.Windows.Forms.TextBox();
            this.reg_dr = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reg_note = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.BTN_Serach = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Group_Per.SuspendLayout();
            this.Group_Reg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab_id_reg);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 89);
            this.panel1.TabIndex = 0;
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lab_date.Location = new System.Drawing.Point(16, 43);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(115, 39);
            this.lab_date.TabIndex = 1;
            this.lab_date.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_id_reg
            // 
            this.lab_id_reg.AutoSize = true;
            this.lab_id_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lab_id_reg.Location = new System.Drawing.Point(1018, 43);
            this.lab_id_reg.Name = "lab_id_reg";
            this.lab_id_reg.Size = new System.Drawing.Size(168, 39);
            this.lab_id_reg.TabIndex = 3;
            this.lab_id_reg.Text = "رقم التسجيل";
            // 
            // Group_Per
            // 
            this.Group_Per.Controls.Add(this.lab_id_p);
            this.Group_Per.Controls.Add(this.comb_address);
            this.Group_Per.Controls.Add(this.comb_gender);
            this.Group_Per.Controls.Add(this.dateTimePicker1);
            this.Group_Per.Controls.Add(this.date_dob);
            this.Group_Per.Controls.Add(this.txt_number);
            this.Group_Per.Controls.Add(this.txt_name_p);
            this.Group_Per.Controls.Add(this.label7);
            this.Group_Per.Controls.Add(this.label6);
            this.Group_Per.Controls.Add(this.label5);
            this.Group_Per.Controls.Add(this.label4);
            this.Group_Per.Controls.Add(this.label3);
            this.Group_Per.Controls.Add(this.label2);
            this.Group_Per.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Per.Location = new System.Drawing.Point(164, 146);
            this.Group_Per.Name = "Group_Per";
            this.Group_Per.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group_Per.Size = new System.Drawing.Size(1004, 359);
            this.Group_Per.TabIndex = 2;
            this.Group_Per.TabStop = false;
            this.Group_Per.Text = "بيانات المريض";
            this.Group_Per.Enter += new System.EventHandler(this.Group_Per_Enter);
            // 
            // lab_id_p
            // 
            this.lab_id_p.AutoSize = true;
            this.lab_id_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lab_id_p.Location = new System.Drawing.Point(369, 35);
            this.lab_id_p.Name = "lab_id_p";
            this.lab_id_p.Size = new System.Drawing.Size(169, 39);
            this.lab_id_p.TabIndex = 2;
            this.lab_id_p.Text = "رقم المريض";
            // 
            // comb_address
            // 
            this.comb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_address.FormattingEnabled = true;
            this.comb_address.Items.AddRange(new object[] {
            "صنعاء",
            "عدن",
            "لحج",
            "ابين",
            "حضرموت",
            "تعز",
            "الضالع"});
            this.comb_address.Location = new System.Drawing.Point(14, 300);
            this.comb_address.Name = "comb_address";
            this.comb_address.Size = new System.Drawing.Size(200, 37);
            this.comb_address.TabIndex = 11;
            // 
            // comb_gender
            // 
            this.comb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_gender.FormattingEnabled = true;
            this.comb_gender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comb_gender.Location = new System.Drawing.Point(14, 208);
            this.comb_gender.Name = "comb_gender";
            this.comb_gender.Size = new System.Drawing.Size(200, 37);
            this.comb_gender.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(406, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(433, 36);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // date_dob
            // 
            this.date_dob.CustomFormat = "dd/MM/yyyy";
            this.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dob.Location = new System.Drawing.Point(629, 220);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(210, 36);
            this.date_dob.TabIndex = 8;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(14, 125);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(200, 36);
            this.txt_number.TabIndex = 7;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // txt_name_p
            // 
            this.txt_name_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_p.Location = new System.Drawing.Point(369, 139);
            this.txt_name_p.Name = "txt_name_p";
            this.txt_name_p.Size = new System.Drawing.Size(474, 36);
            this.txt_name_p.TabIndex = 6;
            this.txt_name_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(863, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "تاريخ التسجيل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "الجنس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "تاريخ الميلاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "العنوان";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(932, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم";
            // 
            // Group_Reg
            // 
            this.Group_Reg.Controls.Add(this.label11);
            this.Group_Reg.Controls.Add(this.reg_note);
            this.Group_Reg.Controls.Add(this.reg_price);
            this.Group_Reg.Controls.Add(this.label12);
            this.Group_Reg.Controls.Add(this.reg_dr);
            this.Group_Reg.Controls.Add(this.label9);
            this.Group_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Reg.Location = new System.Drawing.Point(341, 527);
            this.Group_Reg.Name = "Group_Reg";
            this.Group_Reg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Group_Reg.Size = new System.Drawing.Size(827, 188);
            this.Group_Reg.TabIndex = 3;
            this.Group_Reg.TabStop = false;
            this.Group_Reg.Text = "التسجيل";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(711, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "الرسوم";
            // 
            // reg_price
            // 
            this.reg_price.Enabled = false;
            this.reg_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_price.Location = new System.Drawing.Point(471, 140);
            this.reg_price.Name = "reg_price";
            this.reg_price.Size = new System.Drawing.Size(210, 36);
            this.reg_price.TabIndex = 12;
            this.reg_price.Text = "5000";
            this.reg_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reg_dr
            // 
            this.reg_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_dr.FormattingEnabled = true;
            this.reg_dr.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.reg_dr.Location = new System.Drawing.Point(481, 71);
            this.reg_dr.Name = "reg_dr";
            this.reg_dr.Size = new System.Drawing.Size(200, 37);
            this.reg_dr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "الدكتور";
            // 
            // reg_note
            // 
            this.reg_note.Location = new System.Drawing.Point(61, 71);
            this.reg_note.Name = "reg_note";
            this.reg_note.Size = new System.Drawing.Size(272, 72);
            this.reg_note.TabIndex = 19;
            this.reg_note.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(339, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "ملاحظات";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(613, 751);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(364, 79);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // BTN_Serach
            // 
            this.BTN_Serach.Location = new System.Drawing.Point(99, 643);
            this.BTN_Serach.Name = "BTN_Serach";
            this.BTN_Serach.Size = new System.Drawing.Size(200, 72);
            this.BTN_Serach.TabIndex = 22;
            this.BTN_Serach.Text = "بحث";
            this.BTN_Serach.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(93, 591);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(206, 36);
            this.txt_search.TabIndex = 12;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "رقم المريض";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.BTN_Serach);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Group_Reg);
            this.Controls.Add(this.Group_Per);
            this.Controls.Add(this.panel1);
            this.Name = "Reg";
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Group_Per.ResumeLayout(false);
            this.Group_Per.PerformLayout();
            this.Group_Reg.ResumeLayout(false);
            this.Group_Reg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.GroupBox Group_Per;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_name_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comb_address;
        private System.Windows.Forms.ComboBox comb_gender;
        private System.Windows.Forms.Label lab_id_p;
        private System.Windows.Forms.GroupBox Group_Reg;
        private System.Windows.Forms.ComboBox reg_dr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_id_reg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox reg_price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox reg_note;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button BTN_Serach;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label8;
    }
}