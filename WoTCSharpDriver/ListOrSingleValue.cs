using System;
using System.Collections.Generic;
using System.Linq;

namespace WarApiCSharpDriver
{
    public enum CastErrorMode
    {
        ThrowExceptionIfList,
        UseFirstOrDefaultElementIfList
    }

    public class ListOrSingleValue<TValue> : IList<TValue>
    {
        private List<TValue> data;

        public ListOrSingleValue(CastErrorMode castErrorMode = CastErrorMode.ThrowExceptionIfList)
        {
            this.CastErrorMode = castErrorMode;
            data = new List<TValue>();
        }

        public ListOrSingleValue(TValue value, CastErrorMode castErrorMode = CastErrorMode.ThrowExceptionIfList)
        {
            this.CastErrorMode = castErrorMode;
            castErrorMode = CastErrorMode.ThrowExceptionIfList;
            data = new List<TValue>();
            data.Add(value);
        }

        public ListOrSingleValue(IEnumerable<TValue> values, CastErrorMode castErrorMode = CastErrorMode.ThrowExceptionIfList)
        {
            this.CastErrorMode = castErrorMode;
            castErrorMode = CastErrorMode.ThrowExceptionIfList;
            data = new List<TValue>(values);
        }

        public bool IsSingle
        {
            get
            {
                return this.Count == 1 || this.Count == 0;
            }
        }

        public CastErrorMode CastErrorMode { get; set; }

        public static implicit operator TValue(ListOrSingleValue<TValue> listOrSingleValue)
        {
            if (listOrSingleValue.CastErrorMode == CastErrorMode.ThrowExceptionIfList && listOrSingleValue.Count > 1)
            {
                throw new InvalidCastException(string.Format("Object is list with {0} elements. It can be cast to single element", listOrSingleValue.Count));
            }

            if (listOrSingleValue.Count > 0)
            {
                return listOrSingleValue.ElementAt(0);
            }   
            
            return default(TValue);         
        }

        public static implicit operator ListOrSingleValue<TValue>(TValue value)
        {
            return new ListOrSingleValue<TValue>(value);
        }

        public static implicit operator ListOrSingleValue<TValue>(List<TValue> values)
        {
            return new ListOrSingleValue<TValue>(values);
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                var defaultValue = default(TValue).ToString();

                if (defaultValue == null)
                {
                    throw new NullReferenceException("You try use ToString() method for null value");
                }

                return defaultValue.ToString();
            }

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
