using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CustomDicitonary
{

    public class MyDicitonary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        public MyDicitonary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(keys, key) != -1)
            {
                throw new ArgumentException("this key already exists in MyDicitonary");
            }
            else
            {

                var tempKeys = keys;
                var tempValues = values;
                keys = new TKey[tempKeys.Length + 1];
                values = new TValue[tempValues.Length + 1];
                tempKeys.CopyTo(keys, 0);
                tempValues.CopyTo(values, 0);
                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }


        }

        public TKey[] Keys
        {
            get
            {
                return keys;
            }
        }

        public TValue[] Values
        {
            get
            {
                return values;
            }
        }

        public int Length
        {
            get
            {
                return keys.Length;
            }
        }
    }
}