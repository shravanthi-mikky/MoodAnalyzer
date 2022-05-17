using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser.Tests
{
    [TestClass()]
    public class AnalyseMoodTests
    {
        [TestMethod()]
        public void AnalyseMoodMethodTest()
        {
            AnalyseMood a1 = new();
            Assert.AreEqual("Sad",a1.AnalyseMoodMethod("I am in sad mood"));
        }
    }
}