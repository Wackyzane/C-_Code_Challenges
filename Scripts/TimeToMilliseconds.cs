using System;

// Given Hours, Minutes, and Seconds, give time in Milliseconds
public static int Past(int h, int m, int s)
{
    return (h * 3600000) + (m * 60000) + (s * 1000);
}