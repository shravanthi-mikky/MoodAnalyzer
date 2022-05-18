// See https://aka.ms/new-console-template for more information
using Mood_Analyser;

Console.WriteLine("Mood Analyser!");
AnalyseMood a0 = new();
string mood0 = a0.AnalyseMoodMethod("I am in sad mood");
Console.WriteLine(mood0);

AnalyzeMoodUsingConstructor a1 = new();
string mood1 = a1.AnalyseMoodMethod1();
Console.WriteLine("Using the Default Constructor here and mood is:"+mood1);

AnalyzeMoodUsingConstructor a2 = new("I am in Happy Mood");
string mood2 = a2.AnalyseMoodMethod1();
Console.WriteLine("Using the Parameterized Constructor here and mood is:" + mood2);