using System; 

class Entry


{
   // public List<string> _entries = new List<string> ();
    public List<string> questions = new List<string> ()
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
    };
    public void QuestionOption()  
    {
        foreach (string question in questions)
        {
            Console.WriteLine(question);
        }
    }

    public string RandomQuestions() 
    {
        Random random = new Random();
        int question = random.Next(questions.Count);
        return questions[question]; 
    }

   


}
