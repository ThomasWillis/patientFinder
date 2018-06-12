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
    public partial class DischargeForm : Form
    {
        //Under construction!!
        public DischargeForm()
        {
            InitializeComponent();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Form newForm = new FirstForm();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            newForm.Focus();
        }
    }
}
