using System;

// Checks string for duplicate characters.
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