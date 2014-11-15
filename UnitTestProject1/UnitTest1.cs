using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] input = new int[,] { { 1 } };
            var expect = new int[,] { { 0 } };
            var actual = Game.Next(input);
            CollectionAssert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[,] input = new int[,] { { 1,1 },{1,1} };
            var expect = new int[,] { { 1 ,1} ,{1,1}};
            var actual = Game.Next(input);
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}
