using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Task3
    {
        public int X { get; set; } = 0;
        int Y = 1;
        public Task3(int x, int y)
        {
            if (y != 0)
            {
                X = x;
                Y = y;
            }
            else
            {
                bool check = true;
                while (check)
                {
                    Console.WriteLine("Enter new num y is 0");
                    y = int.Parse(Console.ReadLine());
                    if (y != 0) check = false;
                }
                X = x;
                Y = y;
            }
        }
        public void sety(int val)
        {
            if (val != 0)
            {
                Y = val;
            }
        }
        public int gety()
        {
            return Y;
        }
        public static Task3 operator +(Task3 v, Task3 v1)
        {
            int nx = 0;
            int ny = 0;
            if(v.Y != v1.Y)
            {
                nx = v.X * v1.Y + v1.X * v.Y;
                ny = v.Y * v1.Y;
                return new Task3 ( nx, ny);
            }
            else
            {
                return new Task3(v.X+v1.X, v.Y);
            }
        }
        public void Simplify()
        {
            int tx = X;
            int ty = Y;
            for (int i = 2; i < (tx > ty ? tx : ty); i++)
            {
                if (tx%i == 0 && ty%i == 0)
                {
                    tx /= i;
                    ty /= i;
                    i = 2;
                }
            }
            Y = ty;
            X = tx;
        }
    }
}
