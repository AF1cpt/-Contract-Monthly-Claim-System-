using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMCS_GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Basic Login Validation
            if (UsernameTextBox.Text != "lecturer" || PasswordBox.Password != "password")
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            else
            {
                // Open the Lecturer Dashboard
                LecturerDashboard lecturerDashboard = new LecturerDashboard();
                lecturerDashboard.Show();
                this.Close(); // Close the login window
            }
        }
    }
}