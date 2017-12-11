using System;
using System.IO;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        #endregion

        // If the user clicks OK to save the Student details, validate the information that the user has provided
        private void ok_Click(object sender, RoutedEventArgs e)
        {

           // TODO: Exercise 2: Task 2a: Check that the user has provided a first name
            if (this.firstName.Text == String.Empty)
            {
                MessageBox.Show("The student must have a first name", "Error",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                return;
            }
            // TODO: Exercise 2: Task 2b: Check that the user has provided a last name
            if (String.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
                return;
            }
            // TODO: Exercise 2: Task 3a: Check that the user has entered a valid date for the date of birth
            if (!DateTime.TryParse(this.dateOfBirth.Text, out DateTime validateDate))
            {
                MessageBox.Show("The date of birth must be a valid date", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
                return;
            }
            // TODO: Exercise 2: Task 3b: Verify that the student is at least 5 years old
            TimeSpan validateAge = DateTime.Now.Subtract(validateDate); 
            int age = (int)(validateAge.Days/365.25);
            if (age < 5)
            {
                MessageBox.Show("The age must at least 5 years old", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            // Indicate that the data is valid
            
                this.DialogResult = true;
            
        }
    }
}
