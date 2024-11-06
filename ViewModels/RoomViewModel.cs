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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Assignment02.ViewModels
{
	public class RoomViewModel : BaseViewModel
	{
		public ObservableCollection<RoomInformation> Rooms { get; set; }
		public ObservableCollection<RoomType> RoomTypes { get; set; }
		private RoomInformation _selectedItem;
		public RoomInformation SelectedItem
		{
			get { return _selectedItem; }
			set
			{
				_selectedItem = value;
				OnPropertyChanged(nameof(SelectedItem));
				if (SelectedItem != null)
				{
					NewItem = new RoomInformation
					{
						RoomNumber = SelectedItem.RoomNumber,
						BookingDetails = SelectedItem.BookingDetails,
						RoomDetailDescription = SelectedItem.RoomDetailDescription,
						RoomId = SelectedItem.RoomId,
						RoomMaxCapacity = SelectedItem.RoomMaxCapacity,
						RoomPricePerDay = SelectedItem.RoomPricePerDay,
						RoomStatus = SelectedItem.RoomStatus,
						RoomTypeId = SelectedItem.RoomTypeId,
						RoomType = SelectedItem.RoomType,
					};
					OnPropertyChanged(nameof(NewItem));
				}
			}
		}

		private RoomInformation _newitem;
		public RoomInformation NewItem
		{
			get { return _newitem; }
			set
			{
				_newitem = value;
				OnPropertyChanged(nameof(NewItem));
			}
		}

		public ICommand AddCommand { get; }
		public ICommand UpdateCommand { get; }
		public ICommand DeleteCommand { get; }

		public RoomViewModel()
		{
			NewItem = new();
			Rooms = new ObservableCollection<RoomInformation>();
			RoomTypes = new ObservableCollection<RoomType>();
			Load();
			AddCommand = new RelayCommand(ADD);
			UpdateCommand = new RelayCommand(UPDATE);
			DeleteCommand = new RelayCommand(DELETE);
		}

		private void UPDATE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (SelectedItem != null)
				{
					var room = context.RoomInformations.AsNoTracking().FirstOrDefault(r => r.RoomId == SelectedItem.RoomId);
					if (room != null && ValidateFields())
					{
						room.RoomNumber = NewItem.RoomNumber;
						room.RoomTypeId = NewItem.RoomTypeId;
						room.RoomMaxCapacity = NewItem.RoomMaxCapacity;
						room.RoomPricePerDay = NewItem.RoomPricePerDay;
						room.RoomDetailDescription = NewItem.RoomDetailDescription;
						room.BookingDetails = NewItem.BookingDetails;
						room.RoomStatus = NewItem.RoomStatus;
						room.RoomType = NewItem.RoomType;
						context.Entry(room).State = EntityState.Modified;
						context.SaveChanges();
						Load();
						NewItem = new RoomInformation();
					}
				}
			}
		}

		private void ADD(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (NewItem != null && ValidateFields())
				{
					NewItem.RoomId = 0;
					var roomType = context.RoomTypes.FirstOrDefault(x => x.RoomTypeId == NewItem.RoomTypeId);
					NewItem.RoomType = roomType;
					context.RoomInformations.Add(NewItem);
					context.SaveChanges();
					Rooms.Add(NewItem);
					NewItem = new RoomInformation();
				}
			}
		}

		private void DELETE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (SelectedItem != null)
				{
					var room = context.RoomInformations.FirstOrDefault(x => x.RoomId == SelectedItem.RoomId);
					if (room != null && room.RoomStatus != "0")
					{
						context.RoomInformations.Remove(room);
						context.SaveChanges();
						Rooms.Remove(SelectedItem);
						SelectedItem = null;
						NewItem = new RoomInformation();
					}
					else
					{
						MessageBox.Show("Room is rented so that cannot deleted!", "Deleted Error", MessageBoxButton.OK, MessageBoxImage.Error);
					}

				}
			}
		}

		private void Load()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var items = context.RoomInformations.Include(r => r.RoomType).ToList();
				var roomtypes = context.RoomTypes.ToList();
				RoomTypes.Clear();
				Rooms.Clear();
				foreach (var item in items)
				{
					Rooms.Add(item);
				}
				foreach (var item in roomtypes)
				{
					RoomTypes.Add(item);
				}
			}
		}

		public bool ValidateFields()
		{
			using (var context = new FuminiHotelManagementContext())
			{

				if (string.IsNullOrWhiteSpace(NewItem.RoomNumber))
				{
					MessageBox.Show("Please enter room number!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (NewItem.RoomMaxCapacity < 0)
				{
					MessageBox.Show("Please enter room max capacity and it must be greater than 0!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (string.IsNullOrWhiteSpace(NewItem.RoomDetailDescription))
				{
					MessageBox.Show("Please enter room description!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (NewItem.RoomPricePerDay < 0)
				{
					MessageBox.Show("Please enter price per day and it must be greater than 0!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
			}
			return true;
		}
	}
}
