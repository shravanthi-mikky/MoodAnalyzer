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
    public class MoodAnalyzerExceptionTests
    {
        [TestMethod()]
        public void MoodAnalyzerExceptionMethodTest()
        {
            MoodAnalyzerException a3 = new MoodAnalyzerException();
            string mood3 = a3.MoodAnalyzerExceptionMethod(null);
            Assert.AreEqual("HAPPY", mood3);
        }
    }
}