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
            AnalyseMood a1 = new("I am in sad mood");
            Assert.AreEqual("SAD",a1.AnalyseMoodMethod());
        }
        [TestMethod()]
        public void AnalyseMoodMethodTest1()
        {
            AnalyseMood a1 = new("I am in any mood");
            Assert.AreEqual("HAPPY", a1.AnalyseMoodMethod());
        }

    }
}