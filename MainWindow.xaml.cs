using Assignment02.ViewModels;
using Assignment02.Views.Admin;
using Assignment02.Views.Customer;
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

namespace Assignment02
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		LoginViewModel login = new LoginViewModel();
		public MainWindow()
		{
			InitializeComponent();
			DataContext = login;
		}

		private void loginBtn_Click(object sender, RoutedEventArgs e)
		{

			if (login.ValidateAdminLogin())
			{
				Window admin = new AdminView();
				admin.Show();
				this.Close();
			}
			else if (login.ValidateCustomerLogin())
			{
				Window customer = new CustomerView(login.Email);
				customer.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Email or Password is not correct", "Login is failed!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}