// Return middle character of a string
public static string GetMiddle(string s)
{
    //Code goes here!
    string result = "";
    if (s.Length % 2 == 1) result = s.Substring(s.Length / 2, 1);
    else result = s.Substring(s.Length / 2 - 1, 2);
    return result;
}

// Slightly better version I saw that removed temp variable
public string BetterGetMiddle(string s)
{
    if (s.Length % 2 == 1) return s.Substring(s.Length /2, 1);
    return s.Substring(s.Length / 2 - 1, 2);
}