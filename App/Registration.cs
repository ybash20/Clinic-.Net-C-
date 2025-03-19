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
using System.Threading;

namespace Project_SE
{
    public partial class Registration : Form
    {
        SqlCommand cmd;
        SqlDataAdapter select;

        private void UpdateUI(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public Registration()
        {
            InitializeComponent();
        }
        // جلب آخر رقم تسجيل وزيادته بـ 1
       

        // تحميل بيانات الأطباء
        private void LoadDoctors()
        {
            using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
            {
                try
                {
                    select = new SqlDataAdapter("SELECT Doctor_ID, Doctor_name FROM Doctors", con);
                    DataTable table = new DataTable();
                    select.Fill(table);

                    UpdateUI(() =>
                    {
                        comb_dr_name.DataSource = table;
                        comb_dr_name.DisplayMember = "Doctor_name";
                        comb_dr_name.ValueMember = "Doctor_ID";
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // تحميل بيانات المرضى
        private void LoadPatients()
        {
            using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
            {
                try
                {
                    select = new SqlDataAdapter("SELECT per_no, CONCAT(per_fname, ' ', per_lname) AS FullName FROM personl", con);
                    DataTable table = new DataTable();
                    select.Fill(table);

                    UpdateUI(() =>
                    {
                        comb_per_name.DataSource = table;
                        comb_per_name.DisplayMember = "FullName";
                        comb_per_name.ValueMember = "per_no";
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void GetNextRegistrationNumber()
        {
            using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT ISNULL(MAX(rego_no), 0) + 1 FROM Registration", con);
                    int nextRegoNo = Convert.ToInt32(cmd.ExecuteScalar());

                    UpdateUI(() => { txt_norego.Text = nextRegoNo.ToString(); });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // تحميل بيانات الغرض من الزيارة
        private void LoadVisitPurposes()
        {
            using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
            {
                try
                {
                    select = new SqlDataAdapter("SELECT Purpose_ID, Purpose_Name FROM Visit_Purposes", con);
                    DataTable table = new DataTable();
                    select.Fill(table);

                    UpdateUI(() =>
                    {
                        comb_type_name.DataSource = table;
                        comb_type_name.DisplayMember = "Purpose_Name";
                        comb_type_name.ValueMember = "Purpose_ID";
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }






        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groub_text_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_per_Click(object sender, EventArgs e)
        {
            personl p = new personl();
            p.Show();
            p.checkshow_hide.Visible = false;
            p.MainMenuStrip.Visible = false;
            
        }

        private void rid_rego_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_priserego.Text) || comb_dr_name.SelectedValue == null || comb_per_name.SelectedValue == null || comb_type_name.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
                {
                    string query = @"
                INSERT INTO Registration (dr_no, per_no, Purpose_ID, prics, rego_date)
                VALUES (@dr_no, @per_no, @Purpose_ID, @prics, @rego_date)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dr_no", comb_dr_name.SelectedValue);
                        cmd.Parameters.AddWithValue("@per_no", comb_per_name.SelectedValue);
                        cmd.Parameters.AddWithValue("@Purpose_ID", comb_type_name.SelectedValue);
                        cmd.Parameters.AddWithValue("@prics", txt_priserego.Text);
                        cmd.Parameters.AddWithValue("@rego_date", DateTime.Now);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Registration added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset fields
                comb_dr_name.SelectedIndex = -1;
                comb_per_name.SelectedIndex = -1;
                comb_type_name.SelectedIndex = -1;
                txt_priserego.Text = "5000";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Registration_Load(object sender, EventArgs e)
        {
            // تحميل البيانات في ثريدات لتحسين الأداء
            Thread doctorsThread = new Thread(LoadDoctors);
            Thread patientsThread = new Thread(LoadPatients);
            Thread purposesThread = new Thread(LoadVisitPurposes);
            Thread regoNoThread = new Thread(GetNextRegistrationNumber);

            doctorsThread.Start();
            patientsThread.Start();
            purposesThread.Start();
            regoNoThread.Start();

            // تعيين القيمة الافتراضية لسعر التسجيل
            txt_priserego.Text = "5000";
        }

        private void Registration_Shown(object sender, EventArgs e)
        {

        }

        private void btnadd_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_add_per_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnadd_MouseHover(object sender, EventArgs e)
        {
            btnadd.BackColor = Color.LightSkyBlue;
        }

        private void btn_add_per_MouseHover(object sender, EventArgs e)
        {
            btn_add_per.BackColor = Color.Gold;
        }

        private void btnadd_MouseLeave(object sender, EventArgs e)
        {
            btnadd.BackColor = Color.LightGreen;
        }

        private void btn_add_per_MouseLeave(object sender, EventArgs e)
        {
            btn_add_per.BackColor = Color.LightGray;
        }

        private void comb_dr_name_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void combo_drspecifiy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rid_test_CheckedChanged(object sender, EventArgs e)
        {
            if (rid_test.Checked)
            {
                Testform f = new Testform();
                f.ShowDialog();
                rid_rego.Checked = true;
            }

        }

        private void comb_type_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); // يغلق البرنامج بالكامل
        }


        private void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
