using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    public class DoctorDetails
    {
        public string doctorName { get; set; }

        public DoctorDetails(string dName)
        {
            doctorName = "Dr. " + dName;

        }

        public override string ToString()
        {
            return doctorName;
        }
    }
}
