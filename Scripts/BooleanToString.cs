using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}

// Coding Challenge to turn Bollean into Strings
public static void booleanToString(bool b)
{
	return b.ToString();
}

// Returning Strings
public static void returnGreeting(string name)
{
	return $"Hello, {name} how are you doing today?";
}

public static void summation(int num)
{
	int sum = 0;
	for (int i = 0; i <= num; i++)
	{
		sum += 1;
	}
	return sum;
}