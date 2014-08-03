using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

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
            Assert.AreEqual(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
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
        public void TestIsSinglePropertyForDeafaultValueType()
        {
            var o = new ListOrSingleValue<int>();

            Assert.AreEqual(0, o.Count);
            Assert.IsTrue(o.IsSingle);
            Assert.AreEqual(default(int), (int)o);
        }

        [TestMethod]
        public void TestIsSinglePropertyForDeafaultReferenseType()
        {
            var o = new ListOrSingleValue<List<int>>();

            Assert.AreEqual(0, o.Count);
            Assert.IsTrue(o.IsSingle);
            Assert.IsNull((List<int>)o);
        }

        [TestMethod]
        public void TestImplicitCastFromSingleInt()
        {
            ListOrSingleValue<int> o = 5;

            Assert.AreEqual(1, o.Count);
            Assert.AreEqual(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
            Assert.IsTrue(o.IsSingle);
            Assert.AreEqual(5, o.ElementAt(0));
        }

        [TestMethod]
        public void TestImplicitCastToSingleDefaultInt()
        {
            ListOrSingleValue<int> o = new ListOrSingleValue<int>();

            int intValue = o;

            Assert.AreEqual(0, intValue);
        }

        [TestMethod]
        public void TestImplicitCastFromListInt()
        {
            var list = new List<int> { 10, 12, 15 };
            ListOrSingleValue<int> o = list;

            Assert.AreEqual(3, o.Count);
            Assert.AreEqual(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
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
        public void TestToStringMethodForValuedType()
        {
            var o = new ListOrSingleValue<int>();

            Assert.AreEqual(o.ToString(), default(int).ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestToStringMethodForDefaultReferenceType()
        {
            var o = new ListOrSingleValue<List<int>>();

            o.ToString();
        }

        [TestMethod]
        public void TestCastExceptionModeUseFirstOrDefaultElementIfList()
        {
            var o = new ListOrSingleValue<int>(CastErrorMode.UseFirstOrDefaultElementIfList) { 1, 2, 3 };
            int intValue = o;

            Assert.AreEqual(1, intValue);
        }
    }
}
