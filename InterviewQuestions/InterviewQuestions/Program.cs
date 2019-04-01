using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("求以下表达式的值，写出您想到的一种或几种实现方法：1-2+3-4+……+m");
            Console.WriteLine($"输入4; { SumFn(4)}");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            new B();

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            /*
             37.try{}里有一个return语句，那么紧跟在这个try后的finally {}里的code会
不会被执行，什么时候被执行，在return前还是后?
答：会执行，在return前执行。
             */
            var restult = TryFn();
            Console.WriteLine($"{restult}");
            Console.ReadKey();

        }

        public static int SumFn(int number)
        {
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 1) sum += i;
                else sum -= i;
            }
            return sum;
        }

        public static bool TryFn()
        {
            try
            {
                Console.WriteLine("try");
                return true;
            }
            finally
            {
                Console.WriteLine("执行 finally");
            }
        }


    }

    public class A
    {
        public A()
        {
            PrintFields();
        }
        public virtual void PrintFields()
        {

        }

    }

    public class B : A
    {
        int x = 1;
        int y;
        public B()
        {
            y = -1;
            PrintFields();
        }
        public override void PrintFields()
        {
            Console.WriteLine($"x={x},y={y}");
        }
    }
}
