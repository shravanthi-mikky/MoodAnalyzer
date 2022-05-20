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
    public class MoodAnalyzerFactoryTests
    {
        [TestMethod()]
        public void CreateMoodAnalyserTest()
        {
            object expected = new MoodAnalysisException();
            object actual = MoodAnalyzerFactory.CreateMoodAnalyser("Mood_Analyser.MoodAnalysisException", "MoodAnalysisException");
            expected.Equals(actual);
        }
        [TestMethod]
        public void CreateMoodAnalyserTest1()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyser("2344_MoodAnalyzer.MoodAnalysisException", "MoodAnalysisException");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void CreateMoodAnalyserTest2()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyser("Mood_Analyzer.MoodAnalysisException", "123MoodAnalysisException");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }

}