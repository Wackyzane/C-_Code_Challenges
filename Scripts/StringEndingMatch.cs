using System;

// Checks str to see if it ends with ending
public static bool Solution(string str, string ending)
{
    // TODO: complete
    if (ending.Length == 0) return true;
    if (str.Contains(ending) && str[str.Length - 1] == ending[ending.Length - 1]) return true;
    return false;
}