using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Task2
    {
        public int S { get; set; } = 0;
        public static Task2 operator +(Task2 v, int val)
        {
            v.S += val;
            return v;
        }
        public static Task2 operator -(Task2 v, int val)
        {
            v.S -= val;
            return v;
        }
        public static bool operator ==(Task2 v, Task2 v1)
        {
            return v.S == v1.S;
        }
        public static bool operator !=(Task2 v, Task2 v1)
        {
            return v.S != v1.S;
        }
        public static bool operator >(Task2 v, Task2 v1)
        {
            return v.S > v1.S;
        }
        public static bool operator <(Task2 v, Task2 v1)
        {
            return v.S < v1.S;
        }
    }
}
