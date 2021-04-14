using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    public class Prescription
    {

        public string medicineName;
        public int refills;
        public string patientName;
        public string doctorName;

        public Prescription(string doctorName, string patientName,string medicineName, int refills)
        {
            this.doctorName = doctorName;
            this.patientName = patientName;
            this.medicineName = medicineName;
            this.refills = refills;
        }


    }
}
