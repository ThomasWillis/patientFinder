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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Retrieve data from framework, add to listview box and show
            Patient patient = new Patient();
            Finder find = new Finder();
            patient = find.searchPatient(nameBox.Text);
            try
            {
                patientList.View = View.Details;
                patientList.Columns.Add("Name", -2, HorizontalAlignment.Left);
                patientList.Columns.Add("Date of Birth", -2, HorizontalAlignment.Left);
                patientList.Columns.Add("Hospital Number", -2, HorizontalAlignment.Left);
                patientList.Columns.Add("Date on Ward", -2, HorizontalAlignment.Left);
                ListViewItem items = new ListViewItem(patient.Name);
                items.SubItems.Add(patient.Dob);
                items.SubItems.Add(patient.HospitalNumber.ToString());
                items.SubItems.Add(patient.DateOnWard);
                patientList.Items.Add(items);            }
            catch(Exception ex)
            {

            }
        }

        private void clearList(object sender, MouseEventArgs e)
        {
            patientList.Clear();
        }
    }
}
