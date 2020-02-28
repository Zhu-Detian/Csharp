using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxminAvesum
{
    class Myarray
    {
        double[] nums;
        public void Init(int n)
        {
            if (n == 0)
                throw new Exception(message: "数组为空");
            nums = new double[n];
            Console.WriteLine("请每行输入数组中的一个数：");
            for (int i = 0; i < n; i++)
            {
                double a = 0;
                string inputs = Console.ReadLine();
                while (!double.TryParse(inputs, out a))
                {
                    Console.WriteLine("不合法的输入,请再次输入");
                    inputs = Console.ReadLine();
                }
                nums[i] = a;
            }
        }
        public void Calculate(out double min, out double max, out double avg, out double sum)
        {
            if (nums.Length == 0)
                throw new Exception(message: "数组为空");
            max = nums[0];
            min = nums[0];
            avg = sum = nums[0];
            foreach (double num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            avg = sum / nums.Length;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组长度");
            string inputs = Console.ReadLine();
            int n;
            while (!int.TryParse(inputs, out n) || n < 0)
            {
                Console.WriteLine("非法输入，请再次输入:");
                inputs = Console.ReadLine();
            }
            try
            {
                Myarray myarray = new Myarray();
                myarray.Init(n);
                double min, max, avg, sum;
                myarray.Calculate(out min, out max, out avg, out sum);
                Console.WriteLine($"最大值{max},最小值{min},平均值{avg},总和{sum}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}