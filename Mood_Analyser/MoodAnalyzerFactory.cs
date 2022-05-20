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
    }
}
