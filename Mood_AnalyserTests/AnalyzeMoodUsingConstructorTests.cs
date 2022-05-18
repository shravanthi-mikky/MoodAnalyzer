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
    public class AnalyzeMoodUsingConstructorTests
    {
        [TestMethod()]
        public void AnalyseMoodMethod1Test()
        {
            AnalyzeMoodUsingConstructor a1 = new();
            string mood1 = a1.AnalyseMoodMethod1();
            Assert.AreEqual("SAD", mood1);
        }
    }
}