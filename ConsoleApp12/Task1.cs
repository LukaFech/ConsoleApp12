using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp12
{
    internal class Task1
    {
        public int Amount { get; set; } = 0;
        public static Task1 operator +(Task1 v,int val)
        {
            v.Amount += val;
            return v;
        }
        public static Task1 operator -(Task1 v, int val)
        {
            v.Amount -= val;
            return v;
        }
        public static bool operator ==(Task1 v, Task1 v1)
        {
            return v.Amount == v1.Amount;
        }
        public static bool operator !=(Task1 v, Task1 v1)
        {
            return v.Amount != v1.Amount;
        }
        public static bool operator >(Task1 v, Task1 v1)
        {
            return v.Amount > v1.Amount;
        }
        public static bool operator <(Task1 v, Task1 v1)
        {
            return v.Amount < v1.Amount;
        }
    }
}
