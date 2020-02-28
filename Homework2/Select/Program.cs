using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[102];
            for (int i = 2; i < a.Length; i++)
            {
                a[i] = 1;
            }
            for(int i = 1; i <= 10; i++)
            {
                if(a[i]==1)
                {
                    for (int j=1+i; j <= 100;j++)
                    {
                        if (a[j] == 1 && j % i == 0)
                            a[j] = 0;
                    }
                }
            }
            Console.WriteLine("2-100内的素数为:");
            for(int i = 1; i <= 100; i++)
            {
                if (a[i] == 1)
                {
                    Console.WriteLine(i+"");
                }
            }
        }
    }
}
