// See https://aka.ms/new-console-template for more information
using Mood_Analyser;

Console.WriteLine("Mood Analyser!");

while (true)
{
    Console.WriteLine("Please choose the option :\n1)Basic Mood Analyzer\n2)Using the Default\\Parameterized Constructor\n3)Exception\n4) Mood Custom Exceptions");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            AnalyseMood a0 = new();
            string mood0 = a0.AnalyseMoodMethod("I am in sad mood");
            Console.WriteLine(mood0);
            break;
        case 2:
            AnalyzeMoodUsingConstructor a1 = new();
            string mood1 = a1.AnalyseMoodMethod1();
            Console.WriteLine("Using the Default Constructor here and mood is:" + mood1);

            AnalyzeMoodUsingConstructor a2 = new("I am in Happy Mood");
            string mood2 = a2.AnalyseMoodMethod1();
            Console.WriteLine("Using the Parameterized Constructor here and mood is:" + mood2);
            break;
        case 3:
            MoodAnalyzerException a3 = new MoodAnalyzerException();
            string mood3 = a3.MoodAnalyzerExceptionMethod(null);
            Console.WriteLine(mood3);
            break;
        case 4:
            MoodAnalysisException a4 = new MoodAnalysisException();
            a4.MoodAnalysisExceptionMethod(null);
            break;
        case 5:
            object actual = MoodAnalyzerFactory.CreateMoodAnalyser("Mood_Analyser.MoodAnalysisException", "MoodAnalysisException");
            break;
        default:
            break;
    }
}
