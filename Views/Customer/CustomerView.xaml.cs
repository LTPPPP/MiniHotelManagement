using Assignment02.Models;
using Assignment02.ViewModels;
using Assignment02.ViewModels;
using Assignment02.Views.Admin;
using Microsoft.EntityFrameworkCore;
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

namespace   Assignment02.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        private string _email;
        public CustomerView(string email)
        {
            InitializeComponent();
            _email = email;
        }


        private void profileBtn_Click(object sender, RoutedEventArgs e)
        {
            customerFrame.Content = new ManageProfilePage(_email);
        }

        private void bookingBtn_Click(object sender, RoutedEventArgs e)
        {
            Page detail = new ViewBookingPage();
            BookingViewModel bookVM = new BookingViewModel();
            DetailViewModel detailVM = new  DetailViewModel();

                using (var context = new FuminiHotelManagementContext())
                {
                    var items = context.BookingDetails.Include(x => x.Room).Include(x => x.BookingReservation)
                        .Where(x => x.BookingReservation.Customer.EmailAddress==_email).ToList();
                    foreach (var item in items)
                    {
                        var book = context.BookingReservations.Include(x => x.Customer)
                            .Where(x => x.BookingReservationId == item.BookingReservationId).SingleOrDefault();
                        item.BookingReservation = book;
                        detailVM.Details.Add(item);
                    }
                }
                detail.DataContext = detailVM;
            customerFrame.Content = detail;
            
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Window logout = new MainWindow();
            logout.Show();
            this.Close();
        }
    }
}
