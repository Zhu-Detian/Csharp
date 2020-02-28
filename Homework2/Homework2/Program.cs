using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            string k;
            int num;
            Console.WriteLine("请输入一个正整数:");
            k = Console.ReadLine();
            while(!Int32.TryParse(k,out num))
            { 
                Console.WriteLine("输入数据有误,请重新输入:");
                k=Console.ReadLine();
            }
            Console.WriteLine("该数的所有素数因子为:");
            while (num!=1)
            {
                while(num%i==0)
                { 
                    Console.WriteLine(i);
                    num = num / i;
                }
                i++;
            }
        }
    }
}
