using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINAL_PROJECT_14_06
{
    public partial class MainWindow : Window
    {

        int comboBoxIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            DisplayGrid();
            DisplayCombo();

        }

        public void DisplayGrid()
        {
            PatientDataGrid.ItemsSource = HealthcareDatabase.AllPatientFiles;
        }

        public void DisplayCombo()
        {

            DoccomboBox.ItemsSource = HealthcareDatabase.AllDoctors;

            if (HealthcareDatabase.AllDoctors.Count > 0)
            {
                comboBoxIndex = 0;
                DoccomboBox.SelectedIndex = comboBoxIndex;
            }
        }

        //Add Patient details to grid after verifying the data.
        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            string patientFullName = patientFName.Text + " " + patientLName.Text;
            if (CheckValidityPatient())
            {
                //this FOR loop from https://social.msdn.microsoft.com/Forums/vstudio/en-US/01a15d97-d321-4b93-8757-7b7b07378ee2/get-cell-value-from-wpf-datagrid-c?forum=wpf
                for (int i = 0; i < PatientDataGrid.Items.Count; i++)
                {
                    TextBlock x = PatientDataGrid.Columns[1].GetCellContent(PatientDataGrid.Items[i]) as TextBlock;
                    if (x != null)
                        dummy.Text = x.Text;
                }
                int newRecordNo = int.Parse(dummy.Text);

                PatientDetails newPatient = new PatientDetails(patientFullName, newRecordNo + 1);
                HealthcareDatabase.AllPatientFiles.Add(newPatient);
                RefreshPatientDataGrid();
                scrollDownPatient();
                MessageBox.Show("The record of " + patientFullName + " is Added successfully", "Sucess..!! ");
            }
            else
                MessageBox.Show("Please fill the FirstName and Last Name of Patient..!! ", "ERROR");

            patientFName.Text = "";
            patientLName.Text = "";
            dummy.Text = "";
        }

        private void RemovePatient_Click(object sender, RoutedEventArgs e)//Removes Patient data
        {
            object selectedPatient = PatientDataGrid.SelectedItem;
            if (selectedPatient != null)
            {
                PatientDetails chosenPatient = (PatientDetails)PatientDataGrid.SelectedItem;
                MessageBoxResult removePatient = MessageBox.Show("Do you want to remove the record of " + chosenPatient.patientName, "Delete Item", MessageBoxButton.YesNo);

                if (removePatient == MessageBoxResult.Yes)
                {
                    HealthcareDatabase.AllPatientFiles.Remove(chosenPatient);
                    RefreshPatientDataGrid();
                    MessageBox.Show("The record of " + chosenPatient.patientName + " is Removed successfully", "Sucess..!!, ");
                }
                else
                {
                    MessageBox.Show("Select a recored to delete...", "Error..!!");
                }
            }
        }

        private void VisitDoc_Click(object sender, RoutedEventArgs e)
        {
            Object selectedPatient = PatientDataGrid.SelectedItem;
            object selectedDoctor = DoccomboBox.SelectedItem;
            if (selectedPatient == null || selectedDoctor == null)
            {
                MessageBox.Show("Please select both Patient and Doctor details from lists", "ERROR!!!");
            }
            else
            {
                PatientDetails chosenPatient = (PatientDetails)selectedPatient;
                DoctorDetails chosenDoctor = (DoctorDetails)selectedDoctor;

                Page VisitDoctor = new VisitDoctor(chosenPatient, chosenDoctor, this.Content);
                this.Content = VisitDoctor;

            }
        }

        private void AddDoc_Click(object sender, RoutedEventArgs e)//adding doctor
        {
            if (CheckValidityDoctor())
            {
                string doctorFullName = DocFName.Text + " " + DocLName.Text;
                DoctorDetails newDoc = new DoctorDetails(doctorFullName);
                HealthcareDatabase.AllDoctors.Add(newDoc);
                MessageBox.Show("Record of Dr." + doctorFullName + " is Added Successfully ", "Success..!!");
            }
            else
                MessageBox.Show("Please fill the FirstName and Last Name of Doctor..!! ", "ERROR");

            DocLName.Text = "";
            DocFName.Text = "";
        }

        private void RemoveDoc_Click(object sender, RoutedEventArgs e)//Remove Doctor
        {
            object selectedDoctor = DoccomboBox.SelectedItem;

            if (DoccomboBox.SelectedItem != null)
            {
                MessageBoxResult removeDoctor = MessageBox.Show("Do you want to remove " + DoccomboBox.SelectedItem.ToString(), "Delete Item", MessageBoxButton.YesNo);

                if (removeDoctor == MessageBoxResult.Yes)
                {
                    HealthcareDatabase.AllDoctors.RemoveAt(DoccomboBox.SelectedIndex);
                    MessageBox.Show(" The record of " + DoccomboBox.SelectedItem.ToString() + " deleted", "Success..!!");
                    RefreshDocCombo();
                }
                else
                {
                    MessageBox.Show("Process cancelled        ", "Error..!!");
                }
            }

            else
            {
                MessageBox.Show("Select a recored to delete...           ", "Error..!!");
            }

        }

        private bool CheckValidityPatient() // checks validity of Patient
        {
            bool checkFName, checkLName;

            checkFName = patientFName.Text != "";
            checkLName = patientLName.Text != "";
            return checkFName && checkLName;
        }

        private bool CheckValidityDoctor()// checks validity of Doctor
        {
            bool checkFName, checkLName;

            checkFName = DocFName.Text != "";
            checkLName = DocLName.Text != "";
            return checkFName && checkLName;
        }

        private void patientFName_GotFocus(object sender, RoutedEventArgs e)
        {
            scrollDownPatient();
        }

        public void RefreshPatientDataGrid()
        {
            PatientDataGrid.ItemsSource = null;
            PatientDataGrid.ItemsSource = HealthcareDatabase.AllPatientFiles;
        }

        public void scrollDownPatient() //method from https://stackoverflow.com/questions/1027051/how-to-autoscroll-on-wpf-datagrid
        {
            if (PatientDataGrid.Items.Count > 0)
            {
                var border = VisualTreeHelper.GetChild(PatientDataGrid, 0) as Decorator;
                if (border != null)
                {
                    var scroll = border.Child as ScrollViewer;
                    if (scroll != null) scroll.ScrollToEnd();
                }
            }

        }

        public void RefreshDocCombo()
        {
            //   comboBoxIndex = DoccomboBox.SelectedIndex;

            DoccomboBox.ItemsSource = null;
            DoccomboBox.ItemsSource = HealthcareDatabase.AllDoctors;
            if (HealthcareDatabase.AllDoctors.Count > 0)
            {
                comboBoxIndex = 0;
                DoccomboBox.SelectedIndex = comboBoxIndex;
            }
        }

        private void VisitPhar_Click(object sender, RoutedEventArgs e)
        {
            Object selectedPatient = PatientDataGrid.SelectedItem;

            if (selectedPatient == null)
            {
                MessageBox.Show("Please select Patient details from lists", "ERROR!!!");
            }
            else
            {
                PatientDetails chosenPatient = (PatientDetails)selectedPatient;

                Page PharmacyPage = new PharmacyPage(chosenPatient, this.Content);
                this.Content = PharmacyPage;

            }
        }


    }
}
