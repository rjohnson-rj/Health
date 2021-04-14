using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    class OverTheCounterMedication : Medication
    {
        public string dosageInstruction;
        public OverTheCounterMedication(string medicineName, double unitPrice, bool needPrescription, string dosageInstruction) : base(medicineName, unitPrice, needPrescription)
        {
            this.dosageInstruction = dosageInstruction;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + "" + dosageInstruction;       
        }

        public override string ToString()
        {
            return base.ToString();
        }




    }
}
