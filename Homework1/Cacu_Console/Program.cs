using System;

namespace Cacu_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a, b;
            char ch;
            Console.WriteLine("请输入第一个运算数");
            s = Console.ReadLine();
            while (!double.TryParse(s, out a))
            {
                if (!double.TryParse(s, out a))
                    Console.WriteLine("输入数据有误");
                continue;
            }
            Console.WriteLine("请选择运算");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("请输入第二个运算数");
            s = Console.ReadLine();
            while (!double.TryParse(s, out b))
            {

                if (!double.TryParse(s, out b))
                    Console.WriteLine("输入数据有误");
                continue;
            }

            switch (ch)
            {
                case '+':
                    Console.WriteLine("运算结果为:{0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("运算结果为:{0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("运算结果为:{0}", a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("除数不可为0");
                    else
                        Console.WriteLine("运算结果为:{0}", a / b);
                    break;
                default:
                    Console.WriteLine("请输入正确运算");
                    break;
            }
        }
    }
}
//第一次提交更改
