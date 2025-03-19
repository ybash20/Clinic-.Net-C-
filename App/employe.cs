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
    public partial class employe : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter da;
       // DataTable td; 
        public employe()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void employe_Load(object sender, EventArgs e)
        {

        }

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            if(emp_name.Text == "" || emp_address.Text == "" || emp_passw.Text == "" || emp_salary.Text == "")
            {
                MessageBox.Show("Plase Give All Value in Entry!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                con = new SqlConnection("server=BILAL; Integrated security = true; database= Clinic");
                cmd = new SqlCommand("insert into employe values('"+emp_name.Text+ "', '"+emp_address.Text+ "', "+emp_salary.Text+ ", '"+emp_passw.Text+"' )", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم الاضافة بنجاح", "Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException r){
                MessageBox.Show("Al-Adel Cilnic " + r.Message);
            }
        }

        private void ch_passw_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_passw.Checked)
            {
                emp_passw.PasswordChar = '\0';
            }
            else
                emp_passw.PasswordChar = '*';
        }

        private void Back_Click(object sender, EventArgs e)
        {
            manger m = new manger();
            m.Show();
            this.Hide();
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            Backup s = new Backup();
            s.Show();
        }
    }
}
