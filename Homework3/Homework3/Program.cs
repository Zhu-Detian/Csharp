using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    abstract class Shape
    {
        abstract public double Area();
        abstract public void Pass();
    }
    class Circle : Shape
    {
        public Circle() {
            Pass();
        }
        double r;
        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public override void Pass()
        {
            while (true) { 
            string radius = "";
            Console.WriteLine("Please input the radius of the circle:");
            radius = Console.ReadLine();
                if (!double.TryParse(radius, out r))
                {
                    Console.WriteLine("Error in,please input again");
                    continue;
                }
                break;
            }
        }
    }
        class Rectangle : Shape
        {
        public Rectangle()
        {
            Pass();
        }
            double width;
            double height;
            public override double Area()
            {
                return width *height;
            }
            public override void Pass()
            {
                string Width="";
                string Height="";
            while (true)
            {
                Console.WriteLine("Please input the width of the rectangle:");
                Width = Console.ReadLine();
                if (!double.TryParse(Width, out width))
                {
                    Console.WriteLine("Error in,please input again");
                    continue;
                }
                Console.WriteLine("Please input the height of the rectangle:");
                Height = Console.ReadLine();
                if (!double.TryParse(Height, out height))
                {
                    Console.WriteLine("Error in,please input again");
                    continue;
                }
                break;
            }
            
        }
            
        
    }
        class Square : Shape
        {
        public Square()
        {
            Pass();
        }
            double length;
            public override double Area()
            {
                return length * length;
            }
            public override void Pass()
            {
                string Length = "";
            while (true)
            {
                Console.WriteLine("Please input the length of the square: ");
                Length = Console.ReadLine();
                if (!double.TryParse(Length, out length))
                {
                    Console.WriteLine("Error in ,please write again ");
                    continue;
                }
                break;
            }
            
        }
        
    }
        class Triangle : Shape
        {
        public Triangle()
        {
            Pass();
        }
            double height;
            double bottom;
            public override double Area()
            {
                return (height * bottom) / 2;
            }
            public override void Pass()
            {
            while (true) { 
                Console.WriteLine("Please input the height of the Triangle:");
                string Height = Console.ReadLine();
                if(!double.TryParse(Height,out height))
                {
                    Console.WriteLine("Error in,please input again");
                    continue;
                }
                Console.WriteLine("Please input the bottom of the Triangle:");
                string Bottom = Console.ReadLine();
                if (!double.TryParse(Bottom, out bottom))
                {
                    Console.WriteLine("Error in,please input again");
                    continue;
                }
                break;
                }
            }
        }
        class Factory
        {
        public static Shape CreateFunc(string name)
            {
                switch (name)
                {
                    case "1":return new Circle();
                    case "2":return new Rectangle();
                    case "3": return new Square();
                    case "4":return new Triangle();
                    default:
                        return null;
                }
            }
        }
        class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please select the shape");
                Console.WriteLine("1.Circle , 2.Rectangle , 3.Square , 4.Triangle");
                string name = Console.ReadLine();
                Shape shape = Factory.CreateFunc(name);
                if (shape != null)
                {
                    Console.WriteLine("Area is :{0}", shape.Area());
                }
                else
                    Console.WriteLine("There's no shape you want");
         }
    }
}
