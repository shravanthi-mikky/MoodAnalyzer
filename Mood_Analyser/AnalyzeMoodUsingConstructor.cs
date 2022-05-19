using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class AnalyzeMoodUsingConstructor
    {
        public string msg1 = "I am in Sad Mood";
        public AnalyzeMoodUsingConstructor(string message)
        {
            this.msg1 = message;
        }
        public AnalyzeMoodUsingConstructor()
        {
        }
        public string AnalyseMoodMethod1()
        {

            string message1 = "SAD";
            if (msg1.ToUpper().Contains(message1.ToUpper()))
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
