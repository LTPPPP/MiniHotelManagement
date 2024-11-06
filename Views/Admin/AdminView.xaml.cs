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
using System.Windows.Shapes;

namespace Assignment02.Views.Admin
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Window logout = new MainWindow();
            logout.Show();
            this.Close();
        }

        private void customerBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrame.Content = new ManageCustomerPage();
        }

        private void roomBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrame.Content = new ManageRoomPage();
        }

        private void bookingBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrame.Content = new ManageBookingPage();
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            adminFrame.Content = new ManageReportPage();
        }
    }
}
