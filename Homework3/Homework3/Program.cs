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
            Random ra = new Random(DateTime.Now.Millisecond);
            while (true) {
                double radius = ra.NextDouble()*100;
                r = radius;
            }
            throw Exception();
        }

        private Exception Exception()
        {
            throw new NotImplementedException();
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
            Random ra = new Random(DateTime.Now.Millisecond);
            double Width = ra.NextDouble() * 100;
            double Height = ra.NextDouble() * 100;
            while (true)
            {
                width = Width;
                height = Height;
            }
            throw Exception();

        }

        private Exception Exception()
        {
            throw new NotImplementedException();
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
            Random ra = new Random(DateTime.Now.Millisecond);
            double Length = ra.NextDouble() * 100;
            while (true)
            {
                length = Length;
            }
            throw Exception();
        }

        private Exception Exception()
        {
            throw new NotImplementedException();
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
            Random ra = new Random(DateTime.Now.Millisecond);
            double Height = ra.NextDouble() * 100;
            double Bottom = ra.NextDouble() * 100;

            while (true)
            {
                height = Height;
                bottom = Bottom;
                }
            throw Exception();
            }

        private Exception Exception()
        {
            throw new NotImplementedException();
        }
    }
        class Factory
        {
        public static Shape CreateFunc(int name)
            {
            Random ra = new Random(DateTime.Now.Millisecond);
            Shape shape = null;
                switch (name)
                {
                    case 1:
                    shape = new Circle();
                    break;
                    case 2:
                    shape=new Rectangle();
                    break;
                    case 3: 
                        shape= new Square();
                    break;
                    case 4:
                    shape=new Triangle();
                    break;
                    default:
                        return null;
                }
            return shape;
            }
        }
        class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0.0;
            Random ra = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10;)
            {
                Console.WriteLine("1.Circle , 2.Rectangle , 3.Square , 4.Triangle");
                int name = ra.Next(1, 4);
                Shape shape = Factory.CreateFunc(name);
                totalArea += shape.Area();
                i++;
            }
            Console.WriteLine(totalArea);
        }
    }
}
