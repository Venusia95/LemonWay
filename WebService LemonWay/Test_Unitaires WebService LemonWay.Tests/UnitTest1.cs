using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitaires_WebService_LemonWay.Tests
{
    [TestClass]
    public class UnitTest1
    {
        localhost.WebService1 obj = new localhost.WebService1();

        [TestMethod]
        public void TestFibonacci()
        {
            Assert.AreEqual(obj.Fibonacci(-15), -1);
            Assert.AreEqual(obj.Fibonacci(0), -1);
            Assert.AreEqual(obj.Fibonacci(1), 1);
            Assert.AreEqual(obj.Fibonacci(123), -1);
            Assert.AreEqual(obj.Fibonacci(10), 55);
            Assert.AreEqual(obj.Fibonacci(70), 190392490709135);
            Assert.AreEqual(obj.Fibonacci(90), 2880067194370816120);
        }

        [TestMethod]
        public void TestXmlJson()
        {
            Assert.AreEqual(obj.XmlToJson("<foo>bar</foo>"), "{\"foo\":\"bar\"}");
            Assert.AreEqual(obj.XmlToJson("<foo>hello</bar>").Substring(0, 7), "Bad Xml");
        }
    }
}
