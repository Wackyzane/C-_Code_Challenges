using System;

// Return List of names that are 4 characters long
public static IEnumerable<string> FriendOrFoe(string[] names)
{
    // Good luck!
    List<string> friend = new List<string>();
    foreach (string name in names)
    {
        if (name.Length == 4) friend.Add(name);
    }
    return friend;
}