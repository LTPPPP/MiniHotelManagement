using Assignment02.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment02.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		private IConfiguration configuration;
		private string _email;
		private string _password;


		public string Email
		{
			get { return _email; }
			set
			{
				_email = value;
				OnPropertyChanged(nameof(Email));
			}
		}
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}


		public LoginViewModel()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json");
			configuration = builder.Build();
		}

		public bool ValidateAdminLogin()
		{
			string emailJson = configuration["DefaultAccount:email"]!;
			string passwordJson = configuration["DefaultAccount:password"]!;
            Console.WriteLine(emailJson);
            Console.WriteLine(passwordJson);
            if (_email == emailJson && _password == passwordJson)
			{

				return true;
			}
			return false;
		}

		public bool ValidateCustomerLogin()
		{
			using (var context = new FuminiHotelManagementContext())
			{
				var customer = context.Customers.FirstOrDefault(x => x.EmailAddress == _email && x.Password == _password);
				if (customer != null)
				{
					return true;
				}
				return false;
			}
		}
	}
}
