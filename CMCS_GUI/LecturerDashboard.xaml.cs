using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace CMCS_GUI
{
    public partial class LecturerDashboard : Window
    {
        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the Claim Submission Form
            ClaimSubmissionForm claimForm = new ClaimSubmissionForm();
            claimForm.Show();
            this.Close();
        }

        private void ViewClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            // This can open a window to display all claims submitted by the lecturer
            MessageBox.Show("View claims functionality will be added later.");
        }
    }
}

