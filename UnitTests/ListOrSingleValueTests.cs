using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoTCSharpDriver;

namespace UnitTests
{
    [TestClass]
    public class ListOrSingleValueTests
    {
        [TestMethod]
        public void TestObjectInitialization()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };

            Assert.AreEqual(3, o.Count);
            Assert.IsFalse(o.IsSingle);
            Assert.AreEqual(1, o.ElementAt(0));
            Assert.AreEqual(2, o.ElementAt(1));
            Assert.AreEqual(3, o.ElementAt(2));
        }

        [TestMethod]
        public void TestIsSingleProperty()
        {
            var o = new ListOrSingleValue<int>();

            o.Add(5);

            Assert.AreEqual(1, o.Count);
            Assert.IsTrue(o.IsSingle);
            Assert.AreEqual(5, o.ElementAt(0));
        }

        [TestMethod]
        public void TestImplicitCastFromSingleInt()
        {
            ListOrSingleValue<int> o = 5;

            Assert.AreEqual(1, o.Count);
            Assert.IsTrue(o.IsSingle);
            Assert.AreEqual(5, o.ElementAt(0));
        }

        [TestMethod]
        public void TestImplicitCastFromListInt()
        {
            var list = new List<int> { 10, 12, 15 };
            ListOrSingleValue<int> o = list;

            Assert.AreEqual(3, o.Count);
            Assert.IsFalse(o.IsSingle);
            Assert.AreEqual(10, o.ElementAt(0));
            Assert.AreEqual(12, o.ElementAt(1));
            Assert.AreEqual(15, o.ElementAt(2));
        }

        [TestMethod]
        public void TestImplicitCastToSingleInt()
        {
            ListOrSingleValue<int> o = 7;
            int value = o;

            Assert.AreEqual(7, value);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestImplicitCastToSingleIntForListCase()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };
            int value = o;
        }

        [TestMethod]
        public void TestToStringMethodForSingleInt()
        {
            ListOrSingleValue<int> o = 8;

            Assert.AreEqual(o.ToString(), "8");
        }

        [TestMethod]
        public void TestToStringMethodForListCase()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };

            Assert.AreEqual(o.ToString(), "1,2,3");
        }

        [TestMethod]
        public void TestToStringMethodForEmptyCase()
        {
            var o = new ListOrSingleValue<int>();

            Assert.AreEqual(o.ToString(), string.Empty);
        }
    }
}
