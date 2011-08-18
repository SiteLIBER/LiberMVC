using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web.Mvc;

/// <summary>
/// extending String & Object via extension methods
/// </summary>
public static class CustomExtensions
{
	public static int ToInt32(this object data)
	{
		int result = (data != null && data.ToString() != "") ? Convert.ToInt32(data) : 0;
		return result;
	}

	public static char? ToChar(this string data)
	{
		char? result = (data != null) ? (char?)Char.Parse(data) : null;
		return result;
	}

	public static double ToDouble(this object data)
	{
		double result = (data != null) ? Convert.ToDouble(data, CultureInfo.InvariantCulture) : 0;
		return result;
	}

	public static string ToShortDateString(this DateTime? data)
	{
		return (data.HasValue) ? data.Value.ToShortDateString() : null;
	}
	
	public static DateTime SetYear(this DateTime data)
	{
		return data.SetYear(DateTime.Now.Year);
	}

	public static DateTime SetYear(this DateTime data, int year)
	{
		return data.AddYears(year - data.Year);
	}


	public static string FormatTitle(this UrlHelper source, string title)
	{
		return Regex.Replace(Regex.Replace(title, "[^\\w]", "-"), "[-]{2,}", "-");
	}

}