using System;
using System.Collections.Generic;

class Journal
{
    public List<string> _entries = new List<string> ();

     public void Display(){
        foreach (string userInput in _entries)
        {
            Console.WriteLine($"Prompt: {userInput}");
        }
    }





}