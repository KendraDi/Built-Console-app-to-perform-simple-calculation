using System;

namespace LabOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
           
            Console.WriteLine("Please enter the length of the room.");
            double Length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the room.");

            double Width = double.Parse(Console.ReadLine());
          
            Console.WriteLine("The perimeter is equal to: "+ (2*Length + 2*Width));

            Console.WriteLine("The area is equal to: "+ Length*Width);

            Console.WriteLine("Continue (y/n)?");











       



            










        }
    }
}
