using System;

// Checks string for duplicate characters.
// Or just use .Distinct() and see if str is the same length... Didn't know that was a thing...
public static bool IsIsogram(string str)
{
    // Code on you crazy diamond!
    char[] characters = str.ToLower().ToCharArray();
    Array.Sort(characters);
    for (int i = 0; i < characters.Length; i++)
    {
        if (i + 1 >= characters.Length) break;
        if (characters[i] == characters[i + 1]) return false;
    }
    return true;
}

public static bool IsBetterIsogram(string str)
{
    return str.ToLower().Distinct().Count() == str.Length;
}