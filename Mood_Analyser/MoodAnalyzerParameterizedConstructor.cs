using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyzerParameterizedConstructor
    {
        
        public static object UsingParameterizedConstructor(string className,string constructorName,string message)
        {
            Type type = typeof(AnalyseMood1);
            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo cnstr = type.GetConstructor(new[] { typeof(string)});
                    object instance = cnstr.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodCustomException1(MoodCustomException1.ExpType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodCustomException1(MoodCustomException1.ExpType.NO_SUCH_CLASS, "Class not found");
            }
        }
        
    }
    public class AnalyseMood1
    {
        public string msg;
        public AnalyseMood1(string Message)
        {
            this.msg = Message;
        }
        public string AnalyseMoodMethod1()
        {
            string message1 = "SAD";
            if (msg.ToUpper().Contains(message1.ToUpper()))
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
