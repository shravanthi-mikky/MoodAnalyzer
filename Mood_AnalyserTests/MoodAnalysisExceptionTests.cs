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
    public class MoodAnalysisExceptionTests
    {
        [TestMethod()]
        public void MoodAnalysisExceptionMethodTest()
        {
            try
            {
                string message = "";
                MoodAnalysisException a4 = new MoodAnalysisException();
            }
            catch (MoodCustomException1 ex)
            {
                Assert.AreEqual("Mood should not be empty",ex.Message);
            }           
        }
        [TestMethod()]
        public void MoodAnalysisExceptionMethodTest1()
        {
            try
            {
                string message = null;
                MoodAnalysisException a4 = new MoodAnalysisException();
            }
            catch (MoodCustomException1 ex)
            {
                Assert.AreEqual("Mood should not be Null", ex.Message);
            }
        }
    }

}