using System;

// Beginner Series #1 School Paperwork
public static void Paperwork(int n, int m)
{
    return Math.Clamp(n, 0, int.MaxValue) * Math.Clamp(m, 0, int.MaxValue); // Math.Max would have been better here
}

// public static void Paperwork () => Math.Max(n, 0) * Math.Max(M, 0)