using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodCustomException1 : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message,
            NO_SUCH_CLASS, NO_SUCH_METHOD,
            NO_SUCH_FIELD
        }
        public readonly ExpType type;

        public MoodCustomException1(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
    public class MoodAnalysisException
    {        
        public string MoodAnalysisExceptionMethod(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodCustomException1(MoodCustomException1.ExpType.Empty_Message, "Mood should not be empty");
                }
                string msg1 = "SAD";
                string msg2 = "HAPPY";
                if (message.ToUpper().Contains(msg1.ToUpper()))
                {
                    return msg1;
                }
                else
                {
                    Console.WriteLine("wrong Input");
                    return msg2;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You have provided null reference!");
                throw new MoodCustomException1(MoodCustomException1.ExpType.Null_Message, "Mood should not be Null");
                return "NULL";
            }
            return default(String);
        }
    }
}

