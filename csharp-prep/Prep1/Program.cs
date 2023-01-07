using System;

class Program
{
    static void Main(string[] args)
    {
        //Learning Activity - C# Prep 1
        //Write a program that asks for your name
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {last_name}, {name} {last_name}!");
        
    }
}