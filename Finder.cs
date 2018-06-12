using PatientFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFinder
{
    class Finder
    {

        public void addPatient(Patient patient)
        {

            //Store patient details into db
            using (PatientDatabaseEntities context = new PatientDatabaseEntities())
            {
                try
                {
                    PatientTable patientTB = new PatientTable
                    {
                        Name = patient.Name,
                        DOB = patient.Dob,
                        HospitalNumber = patient.HospitalNumber,
                        DateOnWard = patient.DateOnWard


                    };
                context.PatientTables.Add(patientTB);
                context.SaveChanges();

                }
                catch (Exception ex) { }

            }
        }

        public Patient searchPatient(string name)
        {
            Patient patient = new Patient();
            using (var context = new PatientDatabaseEntities())
            {
                //Search in db for patient by name
                var patientTable =context.PatientTables.Where(c => c.Name == name).FirstOrDefault();
                try
                {
                    patient.Name = patientTable.Name;
                    patient.Dob = patientTable.DOB;
                    patient.HospitalNumber = (int)patientTable.HospitalNumber;
                    patient.DateOnWard = patientTable.DateOnWard;

                    
                }
                catch(Exception ex)
                {

                }return patient;
            }
        }


    }
}

