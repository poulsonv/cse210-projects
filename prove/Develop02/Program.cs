using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
       
     
        Console.WriteLine(); //line spacene space 
        Console.WriteLine("WELCOME TO DIGITAL JOURNAL PROGRAM"); // The Journal initializy with title
       // Entry entry = new Entry();
       // entry.MyMenu();

        //public void MyMenu()
    //{
        Console.WriteLine();// line space
        
        Console.WriteLine("Please, choose an option: "); // The user write entry dates

        List<string> menuOptions = new List<string> ()
        {
            "1 - Write",
            "2 - Display",
            "3 - Load",
            "4 - Save",
            "5 - Quit",
        };

        string userMenuOption = "";


        while  (userMenuOption != "5")
        {
            foreach(string menu in menuOptions) //faz com que os items da lista apareçam linha por linha
            {
            //this code pass a list in a loop for showing every option in a different line
            Console.WriteLine(menu);
            }
            userMenuOption = Console.ReadLine();
            
            if (userMenuOption == "1") // o conteúdo do parenteses é uma condição
            {   Entry entryQuestion = new Entry();
                Entry entryAnswer = new Entry();
                //RandomQuestions(); // isso chama o método
                entryQuestion._question = entryQuestion.RandomQuestions();
                Console.Write(entryQuestion._question);
                entryAnswer._userAnswer = Console.ReadLine();
                Journal journal1 = new Journal(); // serve para chamar a lista de respostas da classe Journal
                journal1._answers.Add(entryQuestion); // serve para salvar a resposta da pergunta feita ao usuário
                journal1._answers.Add(entryAnswer); // salva a resposta do usuário
                
            }
            else if (userMenuOption == "2")
            {
                Journal journal2 = new Journal();
                journal2.AnswersList();

            }
            //break;
        }


    //}

    }

}
