using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumIntegers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string ret = Calculate.Process("3 1269 1160 1663");

            Assert.IsTrue(ret == "383 777 886");
        }


        [TestMethod]
        public void TestMethod2()
        {
            string ret = Calculate.Process("3 1 1 1");

            Assert.IsTrue(ret == "Impossible");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string ret = Calculate.Process("5 226 223 225 224 227 229 228 226 225 227");

            Assert.IsTrue(ret == "111 112 113 114 115");
        }

        [TestMethod]
        public void TestMethod4()
        {
            string ret = Calculate.Process("5 226 223 225 224 227 229 228 226 225 227");

            Assert.IsTrue(ret == "111 112 113 114 115");
        }

        [TestMethod]
        public void TestMethod5()
        {
            string ret = Calculate.Process("5 216 210 204 212 220 214 222 208 216 210");

            Assert.IsTrue(ret == "101 103 107 109 113");
        }

        [TestMethod]
        public void TestMethod6()
        {
            string ret = Calculate.Process("5 -1 0 -1 -2 1 0 -1 1 0 -1");

            Assert.IsTrue(ret == "-1 -1 0 0 1");
        }

        
    }
}
