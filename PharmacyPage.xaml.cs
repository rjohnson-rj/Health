using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

    public partial class PharmacyPage : Page
    {

        PatientDetails patient;
        object mainPage;
        public int comboBoxIndex = 0;
        public PharmacyPage(PatientDetails patientName, object _mainPage)
        {
            InitializeComponent();
            //
            MedicineDataGrid.ItemsSource = HealthcareDatabase.AllMedications;
            DisplayCombo();

            paientblock.Text = patientName.patientName;
            patient = patientName;
            mainPage = _mainPage;
        }


        public void DisplayCombo()
        {

            PharmacistcomboBox.ItemsSource = HealthcareDatabase.AllPharmacists;

            if (HealthcareDatabase.AllDoctors.Count > 0)
            {
                comboBoxIndex = 0;
                PharmacistcomboBox.SelectedIndex = comboBoxIndex;
            }
        }

        private void DrugInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MedicineDataGrid.SelectedItem != null)
            {
                Medication chosenDrug = (Medication)MedicineDataGrid.SelectedItem;
                MessageBox.Show(chosenDrug.GetInfo());

            }
        }

        private void PurchaseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MedicineDataGrid.SelectedItem != null)
            {
                Medication chosenDrug = (Medication)MedicineDataGrid.SelectedItem;
                if (chosenDrug.needPrescription == false)
                {
                    MessageBox.Show(patient.patientName + "Purchased 1 quantity of " + chosenDrug.medicineName);
                }
                else
                {
                    if (PharmacistcomboBox.SelectedItem != null)
                    {
                        bool checkExistance = false;
                        foreach (Prescription p in HealthcareDatabase.AllPrescription)
                        {
                            if ((patient.patientName == p.patientName) && (MedicineDataGrid.SelectedItem.ToString() == p.medicineName))
                            {
                                string addMsg;
                                string msg = "Pharmacist " + PharmacistcomboBox.SelectedItem + " helped " + patient.patientName
                                   + " to fill the Prescription for" + MedicineDataGrid.SelectedItem.ToString()
                                   + "\n" + patient.patientName + " purchased 1 " + MedicineDataGrid.SelectedItem.ToString()
                                   + ". ";
                                if ((p.refills - 1) == 0)
                                {
                                    addMsg = "\nThis Prescription has no more refills available. A new prescription needed to purchase this drug again.";
                                }
                                else {

                                    addMsg = "\nThis prescription has " + (p.refills - 1) + " refill remaining.";
                                }

                                MessageBox.Show(msg+addMsg);
                                checkExistance = true;
                                p.refills = p.refills - 1;
                            }
                        }
                        if (checkExistance == false)
                        {
                            MessageBox.Show("Pharmacist " + PharmacistcomboBox.SelectedItem + " says that " + patient.patientName
                                    + " does not have a Prescription for " + MedicineDataGrid.SelectedItem.ToString()
                                   + "\nPlease visit a doctor and request for prescription.");
                        }

                    }
                    else
                        MessageBox.Show("This medicine need Prescription. So pharmasist assistance required.\nSelect a Pharmacist to fill the prescription.");
                }
            }

            else
            {
                MessageBox.Show("Please select a Medicine to purchase.");
            }
        }

        private void ExitPharmacyBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Content = mainPage;
            ((MainWindow)Application.Current.MainWindow).RefreshPatientDataGrid();
            ((MainWindow)Application.Current.MainWindow).RefreshDocCombo();
        }
    }
}


