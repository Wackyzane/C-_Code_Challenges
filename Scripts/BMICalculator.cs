using System;

// Calculate your BMI and return your category
public static string Bmi(double weight, double height)
{
    switch (weight / (height * height))
    {
        case <= 18.5:
            return "Underweight";
        case <= 25.0:
            return "Normal";
        case <= 30.0:
            return "Overweight";
        default:
            return "Obese";
    }
}
