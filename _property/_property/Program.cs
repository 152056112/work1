using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _property
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Height = 6d;
            rec.Width = 4d;
            Console.WriteLine("矩形的高为：" + rec.Height);
            Console.WriteLine("矩形的宽为：" + rec.Width);
            Console.WriteLine("矩形的面积为：" + rec.Area);

            Ellipse ell = new Ellipse();
            ell.SimiMajorAxis = 6d;
            ell.SimiMinorAxis = 4d;
            Console.WriteLine("椭圆的半长轴：" + ell.SimiMajorAxis);
            Console.WriteLine("椭圆的半长轴：" + ell.SimiMinorAxis);
            Console.WriteLine("椭圆的面积：" + ell.Area);
        }
    }

    class Rectangle
    {
        private double _height;
        private double _width;

        public double Height
        {
            get
            { return _height; }
            set
            { _height = value; }
        }

        public double Width
        {
            get
            { return _width; }
            set
            { _width = value; }
        }
        public double Area
        { get { return _height * _width; } }
    }

        class Ellipse
        {
            const double PI = 3.14159;
            private double _simiMajorAxis;
            private double _simiMinorAxis;

            public double SimiMajorAxis
            {
                get
                { return _simiMajorAxis; }
                set
                { _simiMajorAxis = value;}
            }

            public double SimiMinorAxis
            {get
                {  return _simiMinorAxis;}
              set
                { _simiMinorAxis = value; }
            }
            public double Area
            {
                get { return PI* _simiMajorAxis* _simiMinorAxis; }
            }
        }
    
}
