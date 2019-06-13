using System;

namespace MyProgram
{
    public class Program
    {
        static void Main()
        {
            Rectangle myRectangle = new Rectangle(2.0, 5);
            double area = myRectangle.Area();
            Console.WriteLine(area);
            Console.WriteLine(Color.Green);
        }
    }
}
