using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Task4
    {
        public string name { get; set;}
        public int Amount { get; set; }
        public uint price { get; set; }
        public static Task4 operator +(Task4 v, int val)
        {
            if (v.Amount + val >= 0)
            {
                v.Amount += val;
                return v;
            }
            return v;
        }
        public static Task4 operator -(Task4 v, int val)
        {
            if (v.Amount - val >= 0)
            {
                v.Amount -= val;
                return v;
            }
            return v;
        }
        public static bool operator ==(Task4 v, Task4 v1)
        {
            return v.price == v1.price;
        }
        public static bool operator !=(Task4 v, Task4 v1)
        {
            return v.price != v1.price;
        }
        public static bool operator >(Task4 v, Task4 v1)
        {
            return v.Amount > v1.Amount;
        }
        public static bool operator <(Task4 v, Task4 v1)
        {
            return v.Amount < v1.Amount;
        }
    }
}
