using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your name and last name:  ");
        string _givenName = Console.ReadLine();

        Console.WriteLine("Writer Locate: (City , State , Country ");
        string _givenPlace = Console.ReadLine();

        DateTime dataEntry = DateTime.Now;

        Console.WriteLine($"{_givenName}, {_givenPlace}.");
        Console.WriteLine($"Day {dataEntry}.");
        
    }
}
public class Journal
{
    static void ShowUserAnswer(string[] args)
    {
        Console.WriteLine("What devious do you face today? ");
        string _givenQuestionOne = Console.ReadLine();

        Console.WriteLine($"My main challenges today have been {_givenQuestionOne}.");

        Console.WriteLine("What have you done to overcome this challenge? ");
        string _givenQuestionTwo = Console.ReadLine();

        Console.WriteLine($"To overcome this challenge I {_givenQuestionTwo}.");

    }
}

public class End
{
    static void ShowUserScripture(string[] args)
    {
        Console.WriteLine("Name a scripture you read or studied today? (mention the reference - ex: 1 Nephi 3:7) ");
        string _askEscripture  = Console.ReadLine();
        string _askReference =  Console.ReadLine();

        Console.WriteLine($"A scripture I read today is {_askEscripture}, and the reference is {_askReference}");
    }

}

public class Save
{
    static void SaveFile(bool[] args)
    {   
        Console.WriteLine("Did you write the reference? ");
        string _referenceScripute = Console.ReadLine();
        if (_referenceScripute == "yes")
        {
            Console.WriteLine("Your document is saved");
        }
        else
        {
            Console.WriteLine("Please quote a scripture reference.");
        }


    }
    
}