using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Journal
{
   public List<Entry> _answers = new List<Entry> ();
    public void AnswersList()
    {
        
        foreach (Entry entry in _answers)
        {
            
            entry.Display();
        }
           

    }
}
    