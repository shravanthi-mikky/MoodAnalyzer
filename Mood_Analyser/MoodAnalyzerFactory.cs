using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyser(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodCustomException1(MoodCustomException1.ExpType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodCustomException1(MoodCustomException1.ExpType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        // uc6 - invoke method using reflection
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("Mood_Analyser.AnalyseMood1");
                object moodAnalyseObject = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("Mood_Analyser.AnalyseMood1", "AnalyseMood1", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodCustomException1(MoodCustomException1.ExpType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
    }

}
