using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HopeLove;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        const string datadir = @"E:\Artificial Intelligence\Project\Hope_Love\HopeLove\bin\Debug\HopeLoveData\";

        [TestMethod]
        public void TestWordSegment1()
        {
            Func.InitializeBrain(datadir);
            string input = "莫莫我爱你";
            List<string> output = Func.WordSegment(input);

            Assert.AreEqual(output.Count, 5);
            Assert.AreEqual(output[0], "莫莫");
            Assert.AreEqual(output[1], "我");
            Assert.AreEqual(output[2], "爱");
            Assert.AreEqual(output[3], "你");
            Assert.AreEqual(output[4], "！");

            Func.DisposeBrain();
        }
    }
}
