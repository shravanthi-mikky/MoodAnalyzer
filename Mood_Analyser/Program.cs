// See https://aka.ms/new-console-template for more information
using Mood_Analyser;

Console.WriteLine("Mood Analyser!");
AnalyseMood a1 = new();
string mood = a1.AnalyseMoodMethod();
Console.WriteLine("Using the Default Constructor here and mood is:"+mood);

AnalyseMood a2 = new("I am in Happy Mood");
string mood1 = a2.AnalyseMoodMethod();
Console.WriteLine("Using the Parameterized Constructor here and mood is:" + mood1);