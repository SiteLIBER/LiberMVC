using System;
using System.Globalization;

/// <summary>
/// extending String & Object via extension methods
/// </summary>
public static class CustomExtensions
{
	static public int ToInt32(this object data)
	{
		int result = (data != null && data.ToString() != "") ? Convert.ToInt32(data) : 0;
		return result;
	}

	static public char? ToChar(this string data)
	{
		char? result = (data != null) ? (char?)Char.Parse(data) : null;
		return result;
	}

	static public double ToDouble(this object data)
	{
		double result = (data != null) ? Convert.ToDouble(data, CultureInfo.InvariantCulture) : 0;
		return result;
	}

	static public string ToShortDateString(this DateTime? data)
	{
		return (data.HasValue) ? data.Value.ToShortDateString() : null;
	}
	
	static public DateTime SetYear(this DateTime data)
	{
		return data.SetYear(DateTime.Now.Year);
	}

	static public DateTime SetYear(this DateTime data, int year)
	{
		return data.AddYears(year - data.Year);
	}
}