using Assignment02.Models;
using Assignment02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment02.ViewModels
{
	public class DetailViewModel : BaseViewModel
	{
		public ObservableCollection<BookingDetail> Details { get; set; }
		public BookingReservation Bookings { get; set; }
		public DetailViewModel()
		{
			Details = new ObservableCollection<BookingDetail>();
			Bookings = new();
		}
	}
}
