using System;

namespace RecursionMethoed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少，用递归算法实现。");
            Console.WriteLine($"第30位:{Foo(30)}");
            Console.ReadKey();
        }

        static int Foo(int i)
        {
            if (i < 0) return 0;
            if (i > 0 && i <= 2) return 1;
            return Foo(i - 1) + Foo(i - 2);
        }
    }
}
