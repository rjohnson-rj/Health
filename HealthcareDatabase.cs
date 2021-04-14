using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_14_06
{
    public static class HealthcareDatabase
    {
        public static List<PatientDetails> AllPatientFiles = new List<PatientDetails>()
        {
            new PatientDetails("Neha John",10001),
            new PatientDetails("Noble Antony", 10002),
            new PatientDetails("Irene Anna", 10003),
            new PatientDetails("Nita John", 10004),
            new PatientDetails("Sam David", 10005),
            new PatientDetails("Dany James", 10006),
            new PatientDetails("Antony Mosses", 10007),
            new PatientDetails("Eliyas Jacky", 10008),
            new PatientDetails("Amy George", 10009),
            new PatientDetails("Libya Tony", 10010)
        };

        public static List<DoctorDetails> AllDoctors = new List<DoctorDetails>()
        {
            new DoctorDetails("James Joseph"),
            new DoctorDetails("Evelyn Tony"),
            new DoctorDetails("Noah Jacob"),
            new DoctorDetails("Leo Oliver")
        };

        public static List<Pharmacist> AllPharmacists = new List<Pharmacist>()
        {
            new Pharmacist("Justin Johny"),
            new Pharmacist("Mathew John"),
            new Pharmacist("Evan Augustin"),
            new Pharmacist("Emmanuel Tom")
        };



        public static List<Medication> AllMedications = new List<Medication>() {
            new OverTheCounterMedication("Anthelios", 12.53, false, "\n-Medicine Doesnot require Prescription\n-Dosage Instruction : 1 pill in the moring and 1 pill in the night"),
            new OverTheCounterMedication("Chlor-Trimeton", 2.35, false, "\n-Medicine Doesnot require Prescription\n-Dosage Instruction : 1 pill at 3 times per day      "),
            new OverTheCounterMedication("Cold Fx", 5.00, false, "\n-Medicine Doesnot require Prescription\n-Dosage Instruction : 1 pill every 6 hours                  " ),
            new OverTheCounterMedication("Jamieson Folic Acid", 10.00, false, "\n-Medicine Doesnot require Prescription\n-Dosage Instruction : 3 pills a Day            " ),

            new PrescriptionMedication("Atorvastatin", 8.25, true, "\n-Medicine require Prescription\n-Dosage Instruction : 1 pill in the moring and 1 pill in the night"),
            new PrescriptionMedication("Levothyroxine", 9.32, true, "\n-Medicine require Prescription\n-Dosage Instruction : 1 pill at 3 times per day           "),
            new PrescriptionMedication("Lisinopril", 5.88, true, "\n-Medicine require Prescription\n-Dosage Instruction : 1 pill every 6 hours                   "),
            new PrescriptionMedication("Gabapentin", 6.83, true, "\n-Medicine require Prescription\n-Dosage Instruction : 3 pills a Day                         " ),
        };

        public static List<Prescription> AllPrescription = new List<Prescription>();


    }
}

