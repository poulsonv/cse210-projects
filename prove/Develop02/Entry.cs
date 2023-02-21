using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Entry
{
    public string _userAnswer;

    public string _question;
    public List<string> questions = new List<string> ()
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
    };
    

    public string RandomQuestions() // precisa ser feito fora do método anterior

    {
        Random random = new Random();
        int _question = random.Next(questions.Count);
        return questions[_question]; 
    }

    public void Display()
    {
        Console.WriteLine($"Prompt: {_question}");
        Console.WriteLine($"Your answer: {_userAnswer}");
        
    }

}
