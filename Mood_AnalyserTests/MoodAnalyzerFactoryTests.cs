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
        // uc6 6.1 TestCase
        [TestMethod()]
        public void InvokeAnalyseMoodTest()
        {
            string expected = "HAPPY";
            string obj = MoodAnalyzerFactory.InvokeAnalyseMood("HAPPY", "AnalyseMoodMethod1");
            Assert.AreEqual(expected, obj);
        }
        // TestCase 6.2
        [TestMethod()]
        public void InvokeAnalyseMoodTest1()
        {
            string expected = "Method is Not Found";
            try
            {
                string obj = MoodAnalyzerFactory.InvokeAnalyseMood("HAPPY", "12AnalyseMoodMethod1");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC - 7.1
        [TestMethod()]
        public void SetFieldTest()
        {
            object Expected = new AnalyseMood1("Happy");
            string result9 = MoodAnalyzerFactory.SetField("Happy", "message2");
            Expected.Equals(result9);
        }
        // TC - 7.2
        [TestMethod()]
        public void SetFieldTest1()
        {
            string expected = "Field is Not Found";
            try
            {
                string result9 = MoodAnalyzerFactory.SetField("Happy", "123_message2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC - 7.3
        [TestMethod()]
        public void SetFieldTest2()
        {
            string expected = "Message should not be null";
            try
            {
                string result9 = MoodAnalyzerFactory.SetField(null, "message2");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}