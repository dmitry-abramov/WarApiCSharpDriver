using System;
using System.Collections.Generic;
using System.Linq;

namespace WoTCSharpDriver
{
    public class ListOrSingleValue<TValue> : IList<TValue>
    {
        private List<TValue> data;

        public ListOrSingleValue()
        {
            data = new List<TValue>();
        }

        public ListOrSingleValue(IEnumerable<TValue> values)
        {
            data = new List<TValue>(values);
        }

        public bool IsSingle
        {
            get
            {
                return this.Count == 1;
            }
        }

        public static implicit operator TValue(ListOrSingleValue<TValue> listOrSingleValue)
        {
            if (listOrSingleValue.IsSingle)
            {
                return listOrSingleValue.ElementAt(0);
            }

            throw new InvalidCastException(string.Format("Object is list with {0} elements. It can be cast to single element", listOrSingleValue.Count));
        }

        public static implicit operator ListOrSingleValue<TValue>(TValue value)
        {
            return new ListOrSingleValue<TValue>() { value };
        }

        public static implicit operator ListOrSingleValue<TValue>(List<TValue> values)
        {
            return new ListOrSingleValue<TValue>(values);
        }

        public override string ToString()
        {
            return string.Join(",", this);
        }

        public int IndexOf(TValue item)
        {
            return data.IndexOf(item);
        }

        public void Insert(int index, TValue item)
        {
            data.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            data.RemoveAt(index);
        }

        public TValue this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public void Add(TValue item)
        {
            data.Add(item);
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Contains(TValue item)
        {
            return data.Contains(item);
        }

        public void CopyTo(TValue[] array, int arrayIndex)
        {
            data.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(TValue item)
        {
            return data.Remove(item);
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
