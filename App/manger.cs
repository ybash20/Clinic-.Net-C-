using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SE
{
    public partial class manger : Form
    {
        public manger()
        {
            InitializeComponent();
        }

        private void per_form_Click(object sender, EventArgs e)
        {
            personl p = new personl();
            p.Show();
            this.Hide();
        }

        private void dr_form_Click(object sender, EventArgs e)
        {
            DRform d = new DRform();
            d.Show();
            this.Hide();
        }

        private void test_form_Click(object sender, EventArgs e)
        {
            Testform t = new Testform();
            t.Show();
            this.Hide();
        }

        private void rego_form_Click(object sender, EventArgs e)
        {

        }

        private void emb_Click(object sender, EventArgs e)
        {
            employe em = new employe();
            em.Show();
            this.Hide();
        }

        private void addnew_emp_Click(object sender, EventArgs e)
        {
            employe em = new employe();
            em.Show();
          
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            Backup s = new Backup();
            s.Show();

        }

        
        private void manger_Load(object sender, EventArgs e)
        {

        }
    }
}
