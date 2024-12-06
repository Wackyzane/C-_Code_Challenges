using System;

// Given rock, paper or scissors. Return who wins.
public static string Rps(string p1, string p2)
{
    if (p1 == p2) return "Draw!";
    if (p1 == "scissors" && p2 == "rock" || p1 == "paper" && p2 == "scissors" || p1 == "rock" && p2 == "paper") return "Player 2 won!";
    if (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock") return "Player 1 won!";
    return "";
}