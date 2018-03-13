using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazılımSınamaProjesi;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrıceTrue()
        {
            Test1 t = new Test1();
             int input= t.FiyatDogruMu("120");
            Assert.AreEqual(1, input);
        }
        [TestMethod]
        public void IsEmpty()
        {
            Test1 t = new Test1();
            int input = t.FiyatDogruMu(" ");
            Assert.AreEqual(0, input);
        }
        [TestMethod]
        public void IsInvalid()
        {
            Test1 t = new Test1();
            int input = t.FiyatDogruMu("asdasd");
            Assert.AreEqual(2, input);
        }
    }
}
