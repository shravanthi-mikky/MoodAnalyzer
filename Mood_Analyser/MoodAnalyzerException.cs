using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyzerException
    {
        public string MoodAnalyzerExceptionMethod(string message)
        {
            try
            {
                string message1 = "SAD";
                string message2 = "HAPPY";
                if (message.ToUpper().Contains(message1.ToUpper()))
                {
                    return message1;
                }
                else if(message.ToUpper().Contains(message2.ToUpper()))
                {
                    return message2;
                }
                
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("You have provided null reference!");
                Console.WriteLine(ex.Message);
                
            }
            return null;
        }
    }
}
