using System;
using System.Collections.Generic;
using System.Linq;
using WarApi.Utilities;
using Xunit;

namespace WarApi.UnitTests
{
    public class ListOrSingleValueTests
    {
        [Fact]
        public void Initialization_List_Correct()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };

            Assert.Equal(3, o.Count);
            Assert.False(o.IsSingle);
            Assert.Equal(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
            Assert.Equal(1, o.ElementAt(0));
            Assert.Equal(2, o.ElementAt(1));
            Assert.Equal(3, o.ElementAt(2));
        }

        [Fact]
        public void IsSingle_ListWithSingleElement_True()
        {
            var o = new ListOrSingleValue<int>();

            o.Add(5);

            Assert.Equal(1, o.Count);
            Assert.True(o.IsSingle);
            Assert.Equal(5, o.ElementAt(0));
        }

        [Fact]
        public void IsSingle_ValuedTypeParameterInt_True()
        {
            var o = new ListOrSingleValue<int>();

            Assert.Equal(0, o.Count);
            Assert.True(o.IsSingle);
            Assert.Equal(default(int), (int)o);
        }

        [Fact]
        public void IsSingle_ReferencedTypeParameter_True()
        {
            var o = new ListOrSingleValue<List<int>>();

            Assert.Equal(0, o.Count);
            Assert.True(o.IsSingle);
            Assert.Null((List<int>)o);
        }

        [Fact]
        public void Initialization_SingleValue_Correct()
        {
            ListOrSingleValue<int> o = 5;

            Assert.Equal(1, o.Count);
            Assert.Equal(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
            Assert.True(o.IsSingle);
            Assert.Equal(5, o.ElementAt(0));
        }

        [Fact]
        public void ImplicitCastToSingle_EmptyListOrSingle_Default()
        {
            ListOrSingleValue<int> o = new ListOrSingleValue<int>();

            int intValue = o;

            Assert.Equal(0, intValue);
        }

        [Fact]
        public void ImplicitCastFromList_ListOfInt_ListOrSingle()
        {
            var list = new List<int> { 10, 12, 15 };

            ListOrSingleValue<int> o = list;

            Assert.Equal(3, o.Count);
            Assert.Equal(o.CastErrorMode, CastErrorMode.ThrowExceptionIfList);
            Assert.False(o.IsSingle);
            Assert.Equal(10, o.ElementAt(0));
            Assert.Equal(12, o.ElementAt(1));
            Assert.Equal(15, o.ElementAt(2));
        }

        [Fact]
        public void ImplicitCastToInt_SingleCase_Int()
        {
            ListOrSingleValue<int> o = 7;

            int value = o;

            Assert.Equal(7, value);
        }

        [Fact()]
        public void ImplicitCastToInt_ListCase_InvalidCastException()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };

            Assert.Throws<InvalidCastException>(() => { int value = o; });
        }

        [Fact]
        public void ToString_SingleCase_SingleValueString()
        {
            ListOrSingleValue<int> o = 8;

            Assert.Equal(o.ToString(), "8");
        }

        [Fact]
        public void ToString_ListCase_CommaSeparatedValues()
        {
            var o = new ListOrSingleValue<int>() { 1, 2, 3 };

            Assert.Equal(o.ToString(), "1,2,3");
        }

        [Fact]
        public void ToString_EmptyIntListCase_IntDefaultValue()
        {
            var o = new ListOrSingleValue<int>();

            Assert.Equal(o.ToString(), default(int).ToString());
        }

        [Fact]
        public void ToString_EmptyReferencedTypeListCase_BullReferenceException()
        {
            var o = new ListOrSingleValue<List<int>>();

            Assert.Throws<NullReferenceException>(() => o.ToString());
        }

        [Fact]
        public void ImplicitCastToSingle_UseFirstOrDefaultElementIfListMode_CastedAsFirstElement()
        {
            var o = new ListOrSingleValue<int>(CastErrorMode.UseFirstOrDefaultElementIfList) { 1, 2, 3 };

            int intValue = o;

            Assert.Equal(1, intValue);
        }
    }
}
