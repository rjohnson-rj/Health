using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    class PrescriptionMedication :Medication
    {
        private string instruction;
        
        public PrescriptionMedication(string medicineName, double unitPrice, bool needPrescription, string instruction) : base(medicineName, unitPrice, needPrescription)
        {
            this.instruction = instruction;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + "" + instruction;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
