using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class AnalyseMood
    {
        public string AnalyseMoodMethod(string message)
        {
            string message1 = "Sad";
            if(message.ToLower().Contains(message1.ToLower()))
            {
                return message1;
            }
            else
            {
                return "Happy";
            }
            
        }
    }
}
