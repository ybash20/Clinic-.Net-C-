namespace Project_SE
{
    partial class Backup
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
            this.btnbackup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnrestor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackup
            // 
            this.btnbackup.BackgroundImage = global::Project_SE.Properties.Resources.bk;
            this.btnbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbackup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnbackup.Location = new System.Drawing.Point(14, 369);
            this.btnbackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(181, 123);
            this.btnbackup.TabIndex = 0;
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_SE.Properties.Resources.backup;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 335);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnrestor
            // 
            this.btnrestor.BackgroundImage = global::Project_SE.Properties.Resources.bk2;
            this.btnrestor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrestor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnrestor.Location = new System.Drawing.Point(227, 369);
            this.btnrestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnrestor.Name = "btnrestor";
            this.btnrestor.Size = new System.Drawing.Size(181, 123);
            this.btnrestor.TabIndex = 2;
            this.btnrestor.UseVisualStyleBackColor = true;
            this.btnrestor.Click += new System.EventHandler(this.btnrestor_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 503);
            this.Controls.Add(this.btnrestor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrestor;
    }
}