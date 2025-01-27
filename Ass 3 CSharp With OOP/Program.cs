using System.Buffers.Text;
using System.Numerics;

namespace Ass_3_CSharp_With_OOP
{
    internal class Program
    {
        #region MyRegion 1
        class Calculator
        {

            public int Add(int x, int y)
            {

                return x + y;
            }

            public int Add(int x, int y, int z)
            {
                return x + y + z;
            }

            public double Add(double x, double y)
            {
                return x + y;

            }

          
        }
        #endregion

        #region MyRegion 2
        class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle()
            {
                this.Width = 0;
                this.Height = 0;

            }
            public Rectangle(int width, int height)
            {
                this.Width = width;
                this.Height = height;

            }

            public Rectangle(int size)
            {
                Width = size;
                Height = size;

            }

        }
        #endregion

        #region MyRegion 3
        class Complex
        {
            private double Real;

            public double real
            {
                get { return Real; }
                set { Real = value; }
            }

            private double Imag;

            public double imag
            {
                get { return Imag; }
                set { Imag = value; }
            }




            public override string ToString()
            {
                return $"Result= {Real} + {Imag}i  ";
            }


            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex
                {

                    Real = c1.Real + c2.Real,
                    Imag = c1.Imag + c2.Imag


                };
            }
            public static Complex operator -(Complex c1, Complex c2)
            {
                return new Complex
                {

                    Real = c1.Real - c2.Real,
                    Imag = c1.Imag - c2.Imag


                };
            }

        }
        #endregion

        //#region MyRegion 4
        //class Employee
        //{
        //    public  void Work()
        //    {
        //        Console.WriteLine("Employee is working");

        //    }

        //}

        //class Manager : Employee
        //{

        //    public new void Work()
        //    {
        //        base.Work();
        //        Console.WriteLine("Manager is managing");


        //    }


        //}

        #endregion

        #region MyRegion 5
        class Parent
        {
            public virtual void Display()
            {
                Console.WriteLine("Message from BaseClass");
            }

        }

        class Derived01 : Parent
        {

            public override void Display()
            {
                Console.WriteLine("Message from Derived01Class");
            }


        }

        class Derived02 : Parent
        {

            public new void Display()
            {
                Console.WriteLine("Message from Derived02Class");
            }


        }
        #endregion

        #region MyRegion 6
        class Duration
        {
            public int Minutes { get; set; }
            public int Hours{ get; set; }
            public int Seconds { get; set; }

            public override string ToString()
            {
                return $"Hour{Hours} , Minutes{Minutes} , Seconds{Seconds}";
            }

            // Override Equals() to compare Duration objects
            public override bool Equals(object obj)
            {
                if (obj is Duration other)
                {
                    return Hours == other.Hours &&
                           Minutes == other.Minutes &&
                           Seconds == other.Seconds;
                }
                return false;
            }

            public override int GetHashCode()
            {
                // Combine attributes to calculate hash code
                return HashCode.Combine(Hours, Minutes, Seconds);
            }
        }



        #endregion


        static void Main(string[] args)
            {
            #region MyRegion 1
            //Calculator calculator = new Calculator();
            //double result = calculator.Add(1.9, 2.9);
            //Console.WriteLine(result);
            #endregion

            #region MyRegion 2
            //Complex c1 = new Complex { real = 3, imag = 6 };
            //Complex c2 = new Complex { real = 9, imag = 9 };
            //Complex c3 = new Complex { real = 3, imag = 6 };

            //c3 = c1 + c2;
            //Console.WriteLine($"  {c1}");
            //Console.WriteLine($"  {c2}");
            //Console.WriteLine($" Result = {c3}");
            //c3 = c1 - c2;
            //Console.WriteLine($"  {c1}");
            //Console.WriteLine($"  {c2}");
            //Console.WriteLine($" Result = {c3}");

            #endregion

            #region MyRegion 3
            //Employee emp = new Employee();
            //Manager manager = new Manager();
            //emp.Work();
            //manager.Work();
            #endregion

            #region MyRegion 4
            //Parent parent = new Parent();
            //Parent derived = new Derived01(); // static binding [refence not object ]
            //Derived01 derived02 = new Derived01(); 
            //Parent derived03 = new Derived02();
            //Derived02 derived04 = new Derived02();

            //parent.Display();
            //derived.Display();
            //derived02.Display();
            //derived03.Display();
            //derived04.Display();
            //override modifies the method in the derived class to replace the base class version. Polymorphism ensures that the derived class method is called regardless of the reference type.
            //new hides the base class method and defines a new method in the derived class. Method resolution is based on the reference type(not the actual object type) and happens at compile-time.

            #endregion



        }
    }
    }
