using System;
using System.Globalization;

/// <summary>
/// extending String & Object via extension methods
/// </summary>
public static class StringExtensions
{
	static public int ToInt32(this object data)
	{
		int result = (data != null && data != "") ? Convert.ToInt32(data) : 0;
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
}