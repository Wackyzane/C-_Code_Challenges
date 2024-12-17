using System;
using System.Linq;
using System.Text.RegularExpressions;

// Check for pin to be 4-6 numbers
public static bool ValidatePin(string pin)
{
    if (pin.Length != 4 && pin.Length != 6) return false;
    if (!pin.All(Char.IsDigit)) return false;
    return true;
}

// OR
public bool RegexValidatePin(string pin)
{
    return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
}