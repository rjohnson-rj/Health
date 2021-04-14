using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    public abstract class Medication
    {
        public string medicineName { set; get; }
        public double unitPrice { set; get; }
        public bool needPrescription { set; get; }

        public virtual string GetInfo()
        {
            return "-Medicine Name is " + medicineName + "\n-Unit Price is " + unitPrice + "\n";
        }


        public Medication(string medicineName, double unitPrice, bool needPrescription)
        {
            this.medicineName = medicineName;
            this.unitPrice = unitPrice;
            this.needPrescription = needPrescription;
        }


        public override string ToString()
        {
            return medicineName;
        }

    }
}
