using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();// line space
        // The Journal initializy with title
        Console.WriteLine("DIGITAL JOURNAL");
        // line space
        Console.WriteLine();
        // The user write entry dates
        Console.WriteLine("Please, choose an option: ");

        List<string> menuOptions = new List<string> ()
        {
            "1 - Write",
            "2 - Display",
            "3 - Load",
            "4 - Save",
            "5 - Quit",
        };


        string userAnswer = ""; 
    

        while  (userAnswer != "5"){
            foreach(string option in menuOptions){
            //this code pass a list in a loop for showing every option in a different line
            Console.WriteLine(option);
            };
            Console.Write("What option did you like? ");
            userAnswer = Console.ReadLine();

            if (userAnswer == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Bye!"); 
                break; 
            }

            else if (userAnswer == "1") 
            {
                Entry entry1 = new Entry(); 
                string option = entry1.RandomQuestions();
                Console.Write(option);
                userAnswer = Console.ReadLine();
            }
        
        }  
       

    }

}