using System;
using System.Globalization;
using System.Windows.Data;

namespace Assignment02.Utilities
{
	public class StatusConverter : IValueConverter
	{
		// Convert the database status to a user-friendly display
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value is string status && status == "1" ? "Available" : "Booked";
		}

		// Convert the display status back to a storable value for the database
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value is string status && status == "Available" ? "1" : "0";
		}
	}
}
