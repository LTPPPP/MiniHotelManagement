using Assignment02.Models;
using Assignment02.Utilities;
using Assignment02.Models;
using Assignment02.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Assignment02.ViewModels;

namespace Assignment02.ViewModels
{
	public class BookingViewModel : BaseViewModel
	{
		private BookingReservation _selecteditem;
		public BookingReservation SelectedItem
		{
			get { return _selecteditem; }
			set
			{
				_selecteditem = value;

				OnPropertyChanged(nameof(SelectedItem));
				if (SelectedItem != null)
				{
					GetDetail(SelectedItem.BookingReservationId);
					OnPropertyChanged(nameof(Details));
					NewItem = new BookingReservation
					{
						BookingDate = SelectedItem.BookingDate,
						BookingDetails = SelectedItem.BookingDetails,
						BookingReservationId = SelectedItem.BookingReservationId,
						BookingStatus = SelectedItem.BookingStatus,
						CustomerId = SelectedItem.CustomerId,
						TotalPrice = SelectedItem.TotalPrice,
					};
					OnPropertyChanged(nameof(NewItem));
				}
			}
		}

		private BookingReservation _newitem;
		public BookingReservation NewItem
		{
			get { return _newitem; }
			set
			{
				_newitem = value;
				OnPropertyChanged(nameof(NewItem));
			}
		}

		public ObservableCollection<BookingReservation> Books { get; set; }
		private BookingDetail _bookDetail;
		public BookingDetail Details
		{
			get
			{
				return _bookDetail;

			}
			set
			{
				_bookDetail = value;
				OnPropertyChanged(nameof(Details));
			}
		}
		public ObservableCollection<RoomInformation> Rooms { get; set; }
		public ObservableCollection<Customer> Customers { get; set; }

		public ICommand AddCommand { get; }
		public ICommand DeleteCommand { get; }
		public ICommand UpdateCommand { get; }
		public ICommand DetailCommand { get; }

		public BookingViewModel()
		{
			NewItem = new BookingReservation();
			Books = new ObservableCollection<BookingReservation>();
			Details = new BookingDetail();
			Rooms = new ObservableCollection<RoomInformation>();
			Customers = new ObservableCollection<Customer>();
			AddCommand = new RelayCommand(ADD);
			UpdateCommand = new RelayCommand(UPDATE);
			DeleteCommand = new RelayCommand(DELETE);
			Load();
		}

		private void DELETE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (SelectedItem != null)
				{
					var detail = context.BookingDetails.FirstOrDefault(x => x.BookingReservationId == SelectedItem.BookingReservationId);
					if (detail != null)
					{
						context.BookingDetails.Remove(detail);
					}
					context.BookingReservations.Remove(SelectedItem);
					context.SaveChanges();
					Load();
					NewItem = new();
					Details = new BookingDetail();
				}
			}
		}

		private void UPDATE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (SelectedItem != null && IsValidate())
				{
					var detail = context.BookingDetails.FirstOrDefault(x => x.BookingReservationId == SelectedItem.BookingReservationId);
					if (detail != null)
					{
						var oldDetail = new BookingDetail
						{
							BookingReservationId = detail.BookingReservationId,
							ActualPrice = NewItem.TotalPrice,
							EndDate = Details.EndDate,
							StartDate = Details.StartDate,
							RoomId = Details.RoomId
						};

						context.BookingDetails.Remove(detail);
						context.SaveChanges();
						context.BookingDetails.Add(oldDetail);
						context.SaveChanges();
					}
					var book = context.BookingReservations
						.FirstOrDefault(x => x.BookingReservationId == SelectedItem.BookingReservationId);
					if (book != null)
					{
						book.CustomerId = NewItem.CustomerId;
						book.Customer = context.Customers.FirstOrDefault(x => x.CustomerId == book.CustomerId);
						context.SaveChanges();
					}

					Load();
					NewItem = new();
					Details = new BookingDetail();
				}
			}
		}

		private void ADD(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (IsValidate())
				{
					NewItem.BookingReservationId = context.BookingReservations.Count() + 1;
					Details.ActualPrice = NewItem.TotalPrice;
					NewItem.BookingDetails = null;
					NewItem.Customer = null;
					DateOnly today = DateOnly.FromDateTime(DateTime.Now);
					NewItem.BookingDate = today;
					context.BookingReservations.Add(NewItem);
					context.SaveChanges();
					Details.BookingReservationId = NewItem.BookingReservationId;
					context.BookingDetails.Add(Details);
					context.SaveChanges();
					Load();
					NewItem = new BookingReservation();
					Details = new BookingDetail();
				}

			}
		}

		private void Load()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var books = context.BookingReservations.Include(b => b.Customer)
						.Include(b => b.BookingDetails).ToList();

				Books.Clear();
				foreach (var item in books)
				{
					var detail = context.BookingDetails
						.FirstOrDefault(d => d.BookingReservationId == item.BookingReservationId);
					if (detail != null)
					{
						item.BookingDetails.Add(detail);
					}
					Books.Add(item);
				}
				var rooms = context.RoomInformations.ToList();
				foreach (var item in rooms)
				{
					Rooms.Add(item);
				}
				var customers = context.Customers.ToList();
				foreach (var item in customers)
				{
					Customers.Add(item);
				}
			}
		}

		public void GetDetail(int id)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				Details = context.BookingDetails.FirstOrDefault(d => d.BookingReservationId == id);
			}
		}

		public bool IsValidate()
		{
			if (Details.StartDate > Details.EndDate)
			{
				MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return false;
			}
			if (Details.EndDate.ToString() == null || Details.StartDate.ToString() == null)
			{
				MessageBox.Show("Please select both Start Date and End Date.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return false;
			}
			if (Details.ActualPrice < 0 || NewItem.TotalPrice == null)
			{
				MessageBox.Show("Please enter a valid Total Price.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
				return false;
			}

			return true;
		}

	}
}
