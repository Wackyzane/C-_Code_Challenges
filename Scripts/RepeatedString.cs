// Return string s concatenated an n number of times.
public static string RepeatStr(int n, string s)
{
    string repeatedString = "";
    for (int i = 0; i < n; i++)
    {
        repeatedString += s;
    }
    return repeatedString;
}
  }