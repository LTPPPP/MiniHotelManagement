using Assignment02.Utilities;
using Assignment02.Models;
using Assignment02.Utilities;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Assignment02.ViewModels;

namespace Assignment02.ViewModels
{
	public class CustomerViewModel : BaseViewModel
	{
		public ObservableCollection<Customer> Customers { get; set; }
		public ICommand AddCommand { get; }
		public ICommand DeleteCommand { get; }
		public ICommand UpdateCommand { get; }
		//Constructor
		public CustomerViewModel()
		{
			Customers = new();
			Load();
			NewItem = new Customer();
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
					var customer = context.Customers.FirstOrDefault(x => x.CustomerId == SelectedItem.CustomerId);
					if (customer != null)
					{
						if (ValidateFields())
						{
							customer.Telephone = NewItem.Telephone;
							customer.CustomerFullName = NewItem.CustomerFullName;
							customer.CustomerBirthday = NewItem.CustomerBirthday;
							customer.CustomerStatus = NewItem.CustomerStatus;
							customer.EmailAddress = NewItem.EmailAddress;
							customer.Password = NewItem.Password;
							context.SaveChanges();
							Load();
							NewItem = new Customer();
						}
					}
				}
			}
		}

		private void DELETE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{

				if (SelectedItem != null)
				{
					context.Customers.Remove(SelectedItem);
					context.SaveChanges();
					Customers.Remove(SelectedItem);
					SelectedItem = null;
					NewItem = new Customer();
				}
			}
		}

		private void ADD(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (NewItem != null && ValidateFields())
				{
					NewItem.CustomerId = 0;
					NewItem.CustomerStatus = "Active";
					context.Customers.Add(NewItem);
					context.SaveChanges();
					Customers.Add(NewItem);
					NewItem = new Customer();
				}
			}
		}

		private void Load()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var items = context.Customers.ToList();
				Customers.Clear();
				foreach (var item in items)
				{
					Customers.Add(item);
				}
			}
		}

		private Customer _selecteditem;
		public Customer SelectedItem
		{
			get { return _selecteditem; }
			set
			{
				_selecteditem = value;
				OnPropertyChanged(nameof(SelectedItem));
				if (SelectedItem != null)
				{
					NewItem = new Customer
					{
						CustomerId = _selecteditem.CustomerId,
						BookingReservations = _selecteditem.BookingReservations,
						CustomerBirthday = _selecteditem.CustomerBirthday,
						CustomerFullName = _selecteditem.CustomerFullName,
						CustomerStatus = _selecteditem.CustomerStatus,
						EmailAddress = _selecteditem.EmailAddress,
						Password = _selecteditem.Password,
						Telephone = _selecteditem.Telephone
					};
					OnPropertyChanged(nameof(NewItem));
				}
			}
		}

		private Customer _newitem;
		public Customer NewItem
		{
			get { return _newitem; }
			set
			{
				_newitem = value;
				OnPropertyChanged(nameof(NewItem));
			}
		}

		public bool ValidateFields()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var customer = context.Customers.FirstOrDefault(x => x.EmailAddress == NewItem.EmailAddress);
				if (string.IsNullOrWhiteSpace(NewItem.CustomerFullName))
				{
					MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (string.IsNullOrWhiteSpace(NewItem.EmailAddress))
				{
					MessageBox.Show("Email is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (!IsValidEmail(NewItem.EmailAddress))
				{
					MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (customer != null)
				{
					MessageBox.Show("Email must not be duplicated!", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (NewItem.CustomerBirthday == null)
				{
					MessageBox.Show("Birthday is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (string.IsNullOrWhiteSpace(NewItem.Telephone))
				{
					MessageBox.Show("Telephone is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (string.IsNullOrWhiteSpace(NewItem.Password))
				{
					MessageBox.Show("Password is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				return true;
			}
		}

		private bool IsValidEmail(string emailAddress)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(emailAddress);
				return addr.Address == emailAddress;
			}
			catch
			{
				return false;
			}
		}

		public void GetSelectedItem(string email)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var item = context.Customers.Where(x => x.EmailAddress == email).FirstOrDefault();
				if (item != null)
				{
					SelectedItem = item;
				}
			}
		}
	}
}
