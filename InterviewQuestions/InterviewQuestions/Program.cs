using System;
using System.Text.RegularExpressions;

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
            int[] array = new int[] { };
            int length = array.Length;
            String str = new String("fdsfd");
            String[] strArra = new string[] { "dfdf" };

            string inputStr = "   xx    xx ";
            var reg = Regex.Replace(inputStr.Trim(), @"\s+|\s+g", " ");
            Console.WriteLine(reg);


            //=======================================================
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



    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNo { get; set; }
    }

    public abstract class AbstractOfficeWorker
    {
        public abstract void Insert(Employee employee);
        public abstract void GenerateReport(Employee employee);
    }


    public class ConcreteBase : AbstractOfficeWorker
    {
        public override void GenerateReport(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle
    {
        public int Long { get; set; }
        public int Wide { get; set; }
    }

    public abstract class AbstractCalcule
    {
        public abstract int compute(Func<Rectangle, int> func);
        public int computeFunc(Func<int> func)
        {
            return func();
        }
    }

    public class InstanceCalculate : AbstractCalcule
    {
        private Rectangle rectangle;
        public InstanceCalculate(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public override int compute(Func<Rectangle, int> func)
        {
            if (func == null) throw new Exception("func 为null");
            var f = func(rectangle);
            return f;
        }
    }

    public class App
    {

        public int CalculateReslut(int Wide, int Long)
        {

            //实现委托类型，根据用户输入的两个数据（分别长和宽），计算矩形的周长和面积，
            //如果输入的长和宽一样，那么就以长方形计算公式计算。
            var rectangle = new Rectangle { Wide = Wide, Long = Long };
            AbstractCalcule abstractCalcule = new InstanceCalculate(rectangle);


            /*
             * 第二种方法
                abstractCalcule.computeFunc(() => { return (Wide + Long) * 2; });
            abstractCalcule.computeFunc(() => { return (Wide * Long); });
             */

            return abstractCalcule.compute(f =>
            {
                if (f.Long == f.Wide)
                {
                    return (f.Long + f.Wide) * 2;//周长
                }
                return (f.Long * f.Wide);//面积
            });


        }
    }
}
