using System;
using System.Globalization;
using System.Windows.Data;

namespace Assignment02.Utilities
{
	public class StatusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// Check the status value and return "active" or "inactive"
			return value is string statusString && statusString == "active" ? "active" : "inactive";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// Return the string "active" or "inactive" directly without mapping to numbers
			if (value is string status && (status == "active" || status == "inactive"))
			{
				return status;
			}
			throw new NotImplementedException();
		}
	}
}
