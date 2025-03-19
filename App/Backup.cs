using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_SE
{
    public partial class Backup : Form
    {
        SqlConnection con = new SqlConnection("server=BILAL; Integrated security = true; database= Clinic");
        SqlCommand cmd;
        public Backup()
        {
            InitializeComponent();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Backup Files(*.Bak) | *.bak";

            if(save.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Backup Database Clinic To Disk = '"+save.FileName+"' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم انشاء نسخة احتاطية بنجاح","Al-Adel Clinic",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnrestor_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Backup Files (*.Bka | *.Bak";
            if (op.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Restore Database Clinic From Disk='" + op.FileName + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة قاعدة البيانات", "Al-Adel Clinic",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }
    }
}
