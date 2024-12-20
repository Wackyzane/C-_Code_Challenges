using System;

// Checks if name starts with an R.
public static string AreYouPlayingBanjo(string name)
{
    //Implement me
    if (Char.ToLower(name[0]) == 'r') return name + " plays banjo";
    return name + " does not play banjo";
}

// Can also do name.ToLower()[0]