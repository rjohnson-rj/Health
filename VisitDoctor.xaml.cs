using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINAL_PROJECT_14_06
{
    public partial class VisitDoctor : Page
    {
        PatientDetails pNameToShow;
        DoctorDetails dNameToShow;
        object mainPage;
        public int comboBoxIndex = 0;
        public int refillValue;
        public VisitDoctor(PatientDetails patientName, DoctorDetails doctorName, object _mainPage)
        {
            InitializeComponent();
            DisplayMedicineCombo();

            RefillCount.Text = "0";

            pNameToShow = patientName;
            dNameToShow = doctorName;
            mainPage = _mainPage;
            AssignValues();
        }

        public void DisplayMedicineCombo()
        {

           // MedicineCombo.ItemsSource = HealthcareDatabase.AllMedications;

            if (HealthcareDatabase.AllMedications.Count > 0)
            {
                foreach (Medication m in HealthcareDatabase.AllMedications)
                {
                    if (m.needPrescription)
                    {
                        comboBoxIndex = 0;
                        MedicineCombo.SelectedIndex = comboBoxIndex;
                        MedicineCombo.Items.Add(m.ToString());
                    }

                }
            }
        }

        public void AssignValues()
        {
            ShowPatient.Text = pNameToShow.patientName;
            ShowDoctor.Text = dNameToShow.doctorName;
        }

        private void refillInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The refill count indicates that how many times this prescription can be used at the pharmacy before it needs to be renewed by the doctor");
        }

        private void RequestPrescriptionBtn_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(RefillCount.Text, out refillValue) != true)
                MessageBox.Show("Please enter numeric values only..!!!", "Error..!!");

            if (MedicineCombo.SelectedItem != null)

            {
                if (refillValue > 0)
                {
                    string medicineName = MedicineCombo.SelectedItem.ToString();
                    Prescription newPrescription = new Prescription(dNameToShow.doctorName, pNameToShow.patientName, medicineName, refillValue);
                    HealthcareDatabase.AllPrescription.Add(newPrescription);

                    MessageBox.Show(dNameToShow.doctorName + " prescribed " + refillValue + " refills of " + medicineName + " to " + pNameToShow.patientName + ".");
                }
                else
                {
                    MessageBox.Show("Plesae enter refill values", "Error..!!");
                }
            }
            else
            {
                MessageBox.Show("Plesae select Medicine Name for prescription.", "Error..!!");
            }

        }

        private void CompleteAppoinmentBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Content = mainPage;
            ((MainWindow)Application.Current.MainWindow).RefreshPatientDataGrid();
            ((MainWindow)Application.Current.MainWindow).RefreshDocCombo();
        }

    }

}
