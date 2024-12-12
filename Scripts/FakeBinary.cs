using System;

// Parse numeric string, any below 5 turns to a 0, any at or above 5 becomes a 1
public static string FakeBin(string x)
{
    string digitString = "";
    foreach (char digit in x)
    {
        if (char.GetNumericValue(digit) < 5) digitString += "0";
        else digitString += "1";
    }
    return digitString;
}