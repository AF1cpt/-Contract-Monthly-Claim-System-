using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CMCS_GUI
{
    /// <summary>
    /// Interaction logic for ClaimSubmissionForm.xaml
    /// </summary>
    public partial class ClaimSubmissionForm : Window
    {
        private const decimal HourlyRate = 500m;  // Assuming a fixed hourly rate of 500

        public ClaimSubmissionForm()
        {
            InitializeComponent();
            HourlyRateTextBox.Text = HourlyRate.ToString("C");  // Format hourly rate as currency
            TotalAmountTextBox.Text = "0";  // Set initial total amount to 0
        }

        // Event handler for calculating the total claim amount when hours worked is changed
        private void HoursWorkedTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateTotalAmount();
        }

        // Event handler for the Submit Claim button
        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered hours worked
            if (decimal.TryParse(HoursWorkedTextBox.Text, out decimal hoursWorked))
            {
                if (hoursWorked <= 0)
                {
                    MessageBox.Show("Please enter a valid number of hours worked.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Calculate total claim amount
                decimal totalAmount = hoursWorked * HourlyRate;

                // Here, you would save the claim information to the database or pass it to the next part of the system.
                MessageBox.Show($"Claim for {hoursWorked} hours (Total: {totalAmount:C}) submitted successfully.", "Claim Submitted", MessageBoxButton.OK, MessageBoxImage.Information);

                // Clear the form for the next claim
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please enter a valid number of hours worked.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Helper method to calculate and display the total amount based on hours worked
        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(HoursWorkedTextBox.Text, out decimal hoursWorked))
            {
                decimal totalAmount = hoursWorked * HourlyRate;
                TotalAmountTextBox.Text = totalAmount.ToString("C");  // Display as currency
            }
            else
            {
                TotalAmountTextBox.Text = "0";  // Reset total amount if input is invalid
            }
        }

        // Helper method to clear the form after submission
        private void ClearForm()
        {
            HoursWorkedTextBox.Clear();
            TotalAmountTextBox.Text = "0";
        }
    }
}

