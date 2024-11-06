using Assignment02.Models;
using Assignment02.ViewModels;
using Assignment02.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Assignment02.Views.Admin
{
    /// <summary>
    /// Interaction logic for ManageReportPage.xaml
    /// </summary>
    public partial class ManageReportPage : Page
    {
        public ManageReportPage()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {

            DateOnly? startDate = DateOnly.FromDateTime((DateTime)startDatePicker.SelectedDate);
            DateOnly? endDate = DateOnly.FromDateTime((DateTime)endDatePicker.SelectedDate);
            Window detail = new DetailView();
            BookingViewModel bookVM = new BookingViewModel();
            DetailViewModel detailVM = new DetailViewModel();
            if (startDate != null && endDate != null)
            {
                using (var context = new FuminiHotelManagementContext())
                {
                    var items = context.BookingDetails.Include(x => x.Room).Include(x => x.BookingReservation)
                        .Where(x => x.StartDate >= startDate.Value && x.EndDate <= endDate.Value).ToList();
                    foreach (var item in items)
                    {
                        var book = context.BookingReservations.Include(x => x.Customer)
                            .Where(x => x.BookingReservationId == item.BookingReservationId).SingleOrDefault();
                        item.BookingReservation = book;
                        detailVM.Details.Add(item);
                    }
                }
                detail.DataContext = detailVM;
                detail.ShowDialog();

            }
            else
            {
                if (startDate == null && endDate == null)
                {
                    MessageBox.Show("Please select both Start Date and End Date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (endDate < startDate)
                {
                    MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }


        }
    }
}

