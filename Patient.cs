using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFinder
{
    
    class Patient
    {

        string name;
        string dob;
        string dateOnWard;
        string dischargeLocation;
        int hospitalNumber;
        //Patient constructor
        public Patient(string name, string dob, int hospitalNumber, string dateOnWard)
        {
            this.dateOnWard = dateOnWard;
            this.dob = dob;
            this.name = name;
            this.hospitalNumber = hospitalNumber;
        }
        
        public Patient() { }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string DateOnWard
        {
            get
            {
                return dateOnWard;
            }

            set
            {
                dateOnWard = value;
            }
        }

        public string DischargeLocation
        {
            get
            {
                return dischargeLocation;
            }

            set
            {
                dischargeLocation = value;
            }
        }

        public int HospitalNumber
        {
            get
            {
                return hospitalNumber;
            }

            set
            {
                hospitalNumber = value;
            }
        }
    }







}
