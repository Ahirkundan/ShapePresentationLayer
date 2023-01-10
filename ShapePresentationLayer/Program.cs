using System;

namespace ShapePresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Circle");
            Console.WriteLine("2 for  Tringle");
            Console.WriteLine("3 for Square");
            Console.WriteLine("4 for Rectangle");
            Console.WriteLine("Enter a shape to calculate Area");

            String input = Console.ReadLine();

            if(!int.TryParse(input,out int choice))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter  the radius for Circle:");
                    input = Console.ReadLine();
                    if (!double.TryParse(input,out double radius)) ;
                    {
                        Console.WriteLine("Invalid Input");
                        return;

                    }
                        

            }

        }
    }
}
