namespace Project_SE
{
    partial class manger
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
            this.addnew_emp = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.main_table = new System.Windows.Forms.ToolStripMenuItem();
            this.الجداولالاساسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dr_form = new System.Windows.Forms.ToolStripMenuItem();
            this.per_form = new System.Windows.Forms.ToolStripMenuItem();
            this.test_form = new System.Windows.Forms.ToolStripMenuItem();
            this.emb = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.الجداولالمتغيرةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rego_form = new System.Windows.Forms.ToolStripMenuItem();
            this.report_mang = new System.Windows.Forms.ToolStripMenuItem();
            this.report_emp = new System.Windows.Forms.ToolStripMenuItem();
            this.report_rego = new System.Windows.Forms.ToolStripMenuItem();
            this.report_per = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addnew_emp
            // 
            this.addnew_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addnew_emp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.addnew_emp.Location = new System.Drawing.Point(94, 389);
            this.addnew_emp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addnew_emp.Name = "addnew_emp";
            this.addnew_emp.Size = new System.Drawing.Size(218, 53);
            this.addnew_emp.TabIndex = 0;
            this.addnew_emp.Text = "اضافة موظف جديد";
            this.addnew_emp.UseVisualStyleBackColor = false;
            this.addnew_emp.Click += new System.EventHandler(this.addnew_emp_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.report.Font = new System.Drawing.Font("Tahoma", 12F);
            this.report.Location = new System.Drawing.Point(94, 476);
            this.report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(218, 53);
            this.report.TabIndex = 1;
            this.report.Text = "التقارير";
            this.report.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_table,
            this.الجداولالمتغيرةToolStripMenuItem,
            this.report_mang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(695, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // main_table
            // 
            this.main_table.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الجداولالاساسيةToolStripMenuItem,
            this.Backup});
            this.main_table.Name = "main_table";
            this.main_table.Size = new System.Drawing.Size(83, 24);
            this.main_table.Text = "الاعدادات";
            // 
            // الجداولالاساسيةToolStripMenuItem
            // 
            this.الجداولالاساسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dr_form,
            this.per_form,
            this.test_form,
            this.emb});
            this.الجداولالاساسيةToolStripMenuItem.Name = "الجداولالاساسيةToolStripMenuItem";
            this.الجداولالاساسيةToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.الجداولالاساسيةToolStripMenuItem.Text = "الجداول الاساسية";
            // 
            // dr_form
            // 
            this.dr_form.Name = "dr_form";
            this.dr_form.Size = new System.Drawing.Size(146, 26);
            this.dr_form.Text = "الدكتور";
            this.dr_form.Click += new System.EventHandler(this.dr_form_Click);
            // 
            // per_form
            // 
            this.per_form.Name = "per_form";
            this.per_form.Size = new System.Drawing.Size(146, 26);
            this.per_form.Text = "المريض";
            this.per_form.Click += new System.EventHandler(this.per_form_Click);
            // 
            // test_form
            // 
            this.test_form.Name = "test_form";
            this.test_form.Size = new System.Drawing.Size(146, 26);
            this.test_form.Text = "الفحص";
            this.test_form.Click += new System.EventHandler(this.test_form_Click);
            // 
            // emb
            // 
            this.emb.Name = "emb";
            this.emb.Size = new System.Drawing.Size(146, 26);
            this.emb.Text = "الموظف";
            this.emb.Click += new System.EventHandler(this.emb_Click);
            // 
            // Backup
            // 
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(200, 26);
            this.Backup.Text = "Backup";
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // الجداولالمتغيرةToolStripMenuItem
            // 
            this.الجداولالمتغيرةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rego_form});
            this.الجداولالمتغيرةToolStripMenuItem.Name = "الجداولالمتغيرةToolStripMenuItem";
            this.الجداولالمتغيرةToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.الجداولالمتغيرةToolStripMenuItem.Text = "الجداول المتغيرة";
            // 
            // rego_form
            // 
            this.rego_form.Name = "rego_form";
            this.rego_form.Size = new System.Drawing.Size(143, 26);
            this.rego_form.Text = "التسجيل";
            this.rego_form.Click += new System.EventHandler(this.rego_form_Click);
            // 
            // report_mang
            // 
            this.report_mang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report_emp,
            this.report_rego,
            this.report_per});
            this.report_mang.Name = "report_mang";
            this.report_mang.Size = new System.Drawing.Size(67, 24);
            this.report_mang.Text = "التقارير";
            // 
            // report_emp
            // 
           
            // 
            // manger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SE.Properties.Resources._7616ce55552d7a8548c7ed5b53aae6f0;
            this.ClientSize = new System.Drawing.Size(695, 629);
            this.Controls.Add(this.report);
            this.Controls.Add(this.addnew_emp);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "manger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manger";
            this.Load += new System.EventHandler(this.manger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnew_emp;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem main_table;
        private System.Windows.Forms.ToolStripMenuItem الجداولالاساسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dr_form;
        private System.Windows.Forms.ToolStripMenuItem per_form;
        private System.Windows.Forms.ToolStripMenuItem test_form;
        private System.Windows.Forms.ToolStripMenuItem الجداولالمتغيرةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rego_form;
        private System.Windows.Forms.ToolStripMenuItem report_mang;
        private System.Windows.Forms.ToolStripMenuItem emb;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        private System.Windows.Forms.ToolStripMenuItem report_emp;
        private System.Windows.Forms.ToolStripMenuItem report_rego;
        private System.Windows.Forms.ToolStripMenuItem report_per;
    }
}