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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

        }

        private void addPatient(object sender, EventArgs e)
        {
            //Retrieves data from boxes
            string name;
            string dob;
            int hosNum;
            if (nameBox.Text == "" && dobBox.Text == "")
            {
                MessageBox.Show("Please enter a valid name!");

                if (hNumberBox.Text == null || hNumberBox.Text == "Hospital number")
                {
                    //Alert for number
                    MessageBox.Show("Please enter a valid number");
                }
            }
            else
            {
                //Store data into variables
                hosNum = int.Parse(hNumberBox.Text);
                name = nameBox.Text;
                dob = dobBox.Text;
                DateTime today = DateTime.Today;
                string date = today.ToString("dd/MM/yyyy");

                Patient patient = new Patient(name, dob, hosNum, date);
                //Store data into entity framework
                Finder find = new Finder();
                find.addPatient(patient);
                MessageBox.Show("Patient was successfully added!");
            }
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
