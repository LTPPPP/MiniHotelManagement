using Assignment02.Models;
using Assignment02.Utilities;
using Assignment02.Models;
using Assignment02.Utilities;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Assignment02.ViewModels;

namespace Assignment02.ViewModels
{
	public class ProfileViewModel : BaseViewModel
	{
		private Customer _customer;
		public Customer Customer
		{

			get
			{
				return _customer;
			}

			set
			{
				_customer = value;
				OnPropertyChanged(nameof(Customer));
			}
		}


		public ICommand UpdateCommand { get; }
		public ProfileViewModel(string email)
		{
			Customer = new Customer();
			Load(email);
			UpdateCommand = new RelayCommand(UPDATE);
		}

		private void UPDATE(object obj)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				if (Customer != null)
				{
					var customer = context.Customers.FirstOrDefault(x => x.CustomerId == Customer.CustomerId);
					if (customer != null)
					{
						if (ValidateFields())
						{
							customer.Telephone = Customer.Telephone;
							customer.CustomerFullName = Customer.CustomerFullName;
							customer.CustomerBirthday = Customer.CustomerBirthday;
							customer.CustomerStatus = Customer.CustomerStatus;
							customer.CustomerStatus = Customer.CustomerStatus;
							context.SaveChanges();
							MessageBox.Show("Update Successfully!", "Successfully!", MessageBoxButton.OK, MessageBoxImage.Information);
						}
					}
					else
					{
						MessageBox.Show("No Find Data");
					}
				}
				else
				{
					MessageBox.Show("No Data");
				}

			}
		}

		public void Load(string email)
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var item = context.Customers.Where(x => x.EmailAddress == email).SingleOrDefault();
				if (item != null)
				{
					Customer = item;
				}
			}
		}
		public bool ValidateFields()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var customer = context.Customers.FirstOrDefault(x => x.EmailAddress == Customer.EmailAddress);
				if (string.IsNullOrWhiteSpace(Customer.CustomerFullName))
				{
					MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (string.IsNullOrWhiteSpace(Customer.EmailAddress))
				{
					MessageBox.Show("Email is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}
				else if (!IsValidEmail(Customer.EmailAddress))
				{
					MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (Customer.CustomerBirthday == null)
				{
					MessageBox.Show("Birthday is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
					return false;
				}

				if (string.IsNullOrWhiteSpace(Customer.Telephone))
				{
					MessageBox.Show("Telephone is required.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
	}
}
