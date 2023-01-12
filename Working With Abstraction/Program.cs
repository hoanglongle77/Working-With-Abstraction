using System;

using Working_With_Abstraction.Problem_2;
using Working_With_Abstraction.Problem_3;
using Working_With_Abstraction.Problem_4;

namespace Working_With_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestProblem2();
        }
        static void TestProblem1()
        {
            int size = int.Parse(Console.ReadLine());
            for (int stCount = 1; stCount <= size; stCount++)
            {
                PrintRow(size, stCount);
            }
            for (int stCount = size - 1; stCount >= 1; stCount--)
            {
                PrintRow(size, stCount);
            }
        }
        static void PrintRow(int figureSize, int starCount)
        {
            for(int i = 0; i < figureSize - starCount; i++)
            {
                Console.Write(" ");
            }
            for(int col = 1; col <starCount; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }

        static void TestProblem2()
        {
            Point p1 = new Point(2,3);
            Point p2 = new Point(3,4);
            Point p3 = new Point(4,5);
            Rectangle myRectangle = new Rectangle(p1, p2);
            Console.WriteLine(myRectangle.Contains(p3)); 
        }

        static void TestProblem3()
        {
            Student s1 = new Student();
            s1.Input();
            s1.ShowInformation();
        }
        static void TestProblem4()
        {
            PriceCalculator t1 = new PriceCalculator(25,5,Season.Spring,Discount.VIP);
            Console.WriteLine($"Here is your final price: {PriceCalculator.Calculate(t1)}"); 
        }
    }
}
