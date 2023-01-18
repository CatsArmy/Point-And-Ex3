using System;

namespace point
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            Point p1 = new Point(r1.Next(-10, 11), r1.Next(-10, 11));
            Point p2 = new Point();
            p2.SetX(r1.Next(-10, 11));
            p2.SetY(r1.Next(-10, 11));
            Point p3 = p1.Mid(p2);
            Console.WriteLine($"P1 is {p1.Description()}");
            Console.WriteLine($"P2 is {p2.Description()}");
            Console.WriteLine($"P3 is {p3.Description()}");
            Console.WriteLine($"The Distance Between P2 and P3 is:{p2.Distance(p3)}");
          
            Console.ReadKey();
        }
    }
}       

