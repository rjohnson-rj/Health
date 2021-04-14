using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    public class PatientDetails
    {
        public string patientName { get; set; }
        public int patientRecordNo { get; set; }


        public PatientDetails(string pFName,int pRecordNo)
        {
            patientName = pFName;
            patientRecordNo = pRecordNo;
        }

    }
}
