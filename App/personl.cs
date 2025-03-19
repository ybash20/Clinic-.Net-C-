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

    public partial class personl : Form
    {
        SqlConnection con = new SqlConnection("server=BILAL; Integrated security = true; database= Clinic");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable td;

        public personl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textnoDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textnameDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDR3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (texphone.Text == "" || txfname.Text == "" || txlname.Text == "" || comaddress.Text == "")
            {
                MessageBox.Show("Plase Give All Value in Entry!", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // استخدام الاستعلام مع المعاملات (parameters) لضمان الأمان وتجنب SQL Injection
                string insertQuery = "INSERT INTO personl (per_fname, per_lname, address, phone) VALUES (@fname, @lname, @address, @phone)";

                // إنشاء الكود
                SqlCommand cmd = new SqlCommand(insertQuery, con);

                // إضافة المعاملات
                cmd.Parameters.AddWithValue("@fname", txfname.Text);
                cmd.Parameters.AddWithValue("@lname", txlname.Text);
                cmd.Parameters.AddWithValue("@address", comaddress.Text);
                cmd.Parameters.AddWithValue("@phone", texphone.Text);

                // فتح الاتصال وتنفيذ الاستعلام
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // عرض رسالة النجاح
                MessageBox.Show("تم الاضافة بنجاح", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تحديث البيانات في DataGridView
                da = new SqlDataAdapter("SELECT * FROM personl", con);
                td = new DataTable();
                da.Fill(td);
                personlDataGridView.DataSource = td;

                // مسح الحقول بعد الإضافة
                texno.Text = "";
                texphone.Text = "";
                comaddress.Text = "";
                txfname.Text = "";
                txlname.Text = "";

                // تفعيل / تعطيل الأزرار حسب الحاجة
                BTNedit.Enabled = false;
                btnadd.Enabled = true;
                BTNdel.Enabled = true;
            }
            catch (SqlException r)
            {
                MessageBox.Show("Al-Adel Cilnic " + r.Message);
            }
        }

        private void text_one_TextChanged(object sender, EventArgs e)
        {

        }

        private void personlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personlBindingSource.EndEdit();

        }

        private void personl_Load(object sender, EventArgs e)
        {


        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from personl";
                string serv = @"server=BILAL; Integrated security = true; database= Clinic";
                SqlConnection conn = new SqlConnection(serv);
                SqlDataAdapter data = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ds.Clear();
                personlDataGridView.DataSource = 0;
                conn.Open();
                data.Fill(ds);
                conn.Close();
                personlDataGridView.DataSource = ds.Tables[0];
            }
            catch (SystemException r)
            {
                MessageBox.Show("Al-Adel Cilnic " + r.Message);
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            if (text_one.Text == "")
            {
                MessageBox.Show("قم بادخل رقم الحقل", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from personl where per_no = " + text_one.Text + "", con);
                DataSet ds = new DataSet();
                ds.Clear();
                personlDataGridView.DataSource = 0;
                con.Open();
                ad.Fill(ds);
                con.Close();
                personlDataGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException r)
            {
                MessageBox.Show("Al-Adel Cilnic " + r.Message);
            }
        }

        private void personlDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNedit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update personl set per_fname='" + txfname.Text + "',per_lname='" + txlname.Text + "',address='" + comaddress.Text + "', phone=" + texphone.Text + " Where per_no= " + texno.Text + "   ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم تعديل البيانات بنجاح", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnadd.Enabled = true;
                BTNdel.Enabled = true;

                btnadd.ForeColor = Color.Black;
                btnadd.BackColor = Color.LightGreen;

                BTNdel.ForeColor = Color.Black;
                BTNdel.BackColor = Color.LightGreen;

                BTNedit.Enabled = false;
                BTNedit.BackColor = Color.GhostWhite;
            }
            catch (SqlException r)
            {
                MessageBox.Show("Error" + r.Message + MessageBoxIcon.Error + MessageBoxButtons.OK);
            }




        }

        private void BTNdel_Click(object sender, EventArgs e)
        {
            if (text_one.Text == "")
            {
                MessageBox.Show("قم بتحديد رقم الحقل", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cmd = new SqlCommand("Delete from personl Where per_no='" + text_one.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم حذف البيانات", "Al-Adel Cilnic", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException R)
            {
                MessageBox.Show("error" + R.Message);
            }
        }

        private void personlDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNedit.ForeColor = Color.Black;
            BTNedit.BackColor = Color.LightGreen;
            BTNedit.Enabled = true;
            texno.Enabled = false;
            btnadd.Enabled = false;
            btnadd.BackColor = Color.GhostWhite;
            BTNdel.Enabled = false;
            BTNdel.BackColor = Color.GhostWhite;

            texno.Text = personlDataGridView.CurrentRow.Cells[0].Value.ToString();
            txfname.Text = personlDataGridView.CurrentRow.Cells[1].Value.ToString();
            txlname.Text = personlDataGridView.CurrentRow.Cells[2].Value.ToString();
            comaddress.Text = personlDataGridView.CurrentRow.Cells[3].Value.ToString();
            texphone.Text = personlDataGridView.CurrentRow.Cells[4].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Width = 840;
            this.Height = 460;
            this.Location = new Point(120, 50);
            label6.Visible = true;

            text_one.Visible = true;
            btn_one.Visible = true;
            btn_all.Visible = true;
            BTNedit.Visible = true;
            BTNdel.Visible = true;
            personlDataGridView.Visible = true;


        }

        private void personl_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void texno_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txlname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txfname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comaddress_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void texphone_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comaddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTNhide_Click(object sender, EventArgs e)
        {
            this.Width = 345;
            this.Height = 460;
            this.Location = new Point(120, 50);
            label6.Visible = false;

            text_one.Visible = false;
            btn_one.Visible = false;
            btn_all.Visible = false;
            BTNedit.Visible = false;
            BTNdel.Visible = false;
            personlDataGridView.Visible = false;
        }

        private void checkshow_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshow_hide.Checked)
            {
                this.Width = 840;
                this.Height = 480;
                this.Location = new Point(120, 50);
                label6.Visible = true;

                text_one.Visible = true;
                btn_one.Visible = true;
                btn_all.Visible = true;
                BTNedit.Visible = true;
                BTNdel.Visible = true;
                personlDataGridView.Visible = true;
                checkshow_hide.Text = "اخفاء";
            }
            else
            {
                checkshow_hide.Text = "عرض التفاصيل";
                this.Width = 345;
                this.Height = 480;
                this.Location = new Point(120, 50);
                label6.Visible = false;

                text_one.Visible = false;
                btn_one.Visible = false;
                btn_all.Visible = false;
                BTNedit.Visible = false;
                BTNdel.Visible = false;
                personlDataGridView.Visible = false;
            }
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            Backup s = new Backup();
            s.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}