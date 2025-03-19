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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // التحقق من إدخال المستخدم وكلمة المرور
            if (string.IsNullOrWhiteSpace(texid.Text) || string.IsNullOrWhiteSpace(texpass.Text))
            {
                MessageBox.Show("Please Enter Username & Password", "Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // استخدام Task لتشغيل العملية في خيط منفصل
            var result = await Task.Run(() => AuthenticateUser(texid.Text, texpass.Text));

            if (result.IsValid)
            {
                if (result.IdRole == 1) // إذا كان المستخدم هو مدير
                {
                    MessageBox.Show("مرحبا", "Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Invoke((MethodInvoker)delegate {
                        new manger().Show();
                        this.Hide();
                    });
                }
                else if (result.IdRole == 2) // إذا كان المستخدم هو موظف
                {
                    MessageBox.Show("اهلا", "Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Invoke((MethodInvoker)delegate {
                        new Registration().Show();
                        this.Hide();
                    });
                }
            }
            else
            {
                MessageBox.Show("Username & Password not Found!", "Al-Adel Clinic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private (bool IsValid, int IdRole) AuthenticateUser(string username, string password)
        {
            using (SqlConnection con = Connection.DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM employe WHERE username=@username AND emp_password=@password", con);
                ad.SelectCommand.Parameters.AddWithValue("@username", username);
                ad.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int idRole = Convert.ToInt32(dt.Rows[0]["id_role"]);
                    return (true, idRole);
                }
                else
                {
                    return (false, 0);
                }
            }
        }

        private void ch_password_CheckedChanged(object sender, EventArgs e)
        {
            texpass.PasswordChar = ch_password.Checked ? '\0' : '*';
        }
    }
}
