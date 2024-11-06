using Assignment02.ViewModels;
using Assignment02.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment02.Views.Customer
{
    /// <summary>
    /// Interaction logic for ManageProfilePage.xaml
    /// </summary>
    public partial class ManageProfilePage : Page
    {
        

        public ManageProfilePage(string email)
        {
            ProfileViewModel vm = new ProfileViewModel(email);
            InitializeComponent();
            DataContext = vm;
        }
    }
}
