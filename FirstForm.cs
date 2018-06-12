using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFinder
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBut_Click(object sender, EventArgs e)
        {
            Form newForm = new AddForm();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            newForm.Focus();
        }

        private void dischBut_Click(object sender, EventArgs e)
        {
            Form newForm = new DischargeForm();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            newForm.Focus();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            Form newForm = new SearchPatient();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            newForm.Focus();
        }
    }
}
