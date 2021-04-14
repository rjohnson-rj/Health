using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
   public class Pharmacist
    {
        public string pharmacistName;

        public Pharmacist(string pharmacist)
        {
            this.pharmacistName = pharmacist;
        }
        public override string ToString()
        {
            return pharmacistName; ;
        }

    }
}
