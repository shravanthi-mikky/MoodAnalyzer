using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser.Tests
{
    [TestClass()]
    public class MoodAnalyzerParameterizedConstructorTests
    {
        [TestMethod()]
        public void UsingParameterizedConstructorTest()
        {
            object Expected = new AnalyseMood1("HAPPY");
            object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("Mood_Analyser.AnalyseMood1", "AnalyseMood1", "HAPPY");
            Expected.Equals(result);
        }
        [TestMethod]
        public void UsingParameterizedConstructorTest1()
        {
            string expected = "Class not found";
            try
            {
                object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("Mood_Analyser.AnalyseMood1", "AnalyseMood1", "HAPPY");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void UsingParameterizedConstructorTest2()
        {
            string expected = "Constructor is not found";
            try
            {
                object result = MoodAnalyzerParameterizedConstructor.UsingParameterizedConstructor("Mood_Analyser.AnalyseMood1", "AnalyseMood1", "HAPPY");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}