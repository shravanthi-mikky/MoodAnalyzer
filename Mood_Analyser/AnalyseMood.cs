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
            string message1 = "SAD";
            if(message.ToUpper().Contains(message1.ToUpper()))
            {
                return message1;
            }
            else
            {
                return "HAPPY";
            }   
        }
    }
}
