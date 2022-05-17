// See https://aka.ms/new-console-template for more information
using Mood_Analyser;

Console.WriteLine("Mood Analyser!");
AnalyseMood a1 = new();
string mood = a1.AnalyseMoodMethod("I am in sad mood");
Console.WriteLine(mood);