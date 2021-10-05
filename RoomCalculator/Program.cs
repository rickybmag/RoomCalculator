using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            //Sets up loop to continue measuring if "y" is selected
            do
            {
                // Gets measurement of classroom
                Console.WriteLine("Please input the length of the classroom: ");

                string length = Console.ReadLine();
                double l = double.Parse(length);

                Console.WriteLine("Please input the width of the classroom: ");
                string width = Console.ReadLine();
                double w = double.Parse(width);

                Console.WriteLine("Please input the height of the classroom: ");
                string height = Console.ReadLine();
                double h = double.Parse(height);

                // Calcuates measurements and paint/tile needed
                double area = l * w;
                double perimeter = (2 * l) + (2 * w);
                double volume = l * w * h;
                double carpet = area / 5;
                double paint = (area + 2 * l * h + 2 * w * h) / 25;
                double p = perimeter / 5;

                //Outputs
                Console.WriteLine($"Classroom length: {l}");
                Console.WriteLine($"Classroom width: {w}");
                Console.WriteLine($"Classroom height: {h}");
                Console.WriteLine();
                Console.WriteLine($"Classroom area: {area}");
                Console.WriteLine($"Classroom volume: {volume}");
                Console.WriteLine($"Classroom perimeter: {perimeter}");
                Console.WriteLine();
                Console.WriteLine($"Tile needed: {carpet}");
                Console.WriteLine($"Paint needed for walls: {paint}");
                Console.WriteLine($"Paint needed for perimeter: {perimeter}");
                Console.WriteLine();

                bool askAgain = true;
                while (askAgain == true)
                {
                    Console.WriteLine("\nWant to measure another room? (Y/N) ");
                    string answer = Console.ReadLine().ToLower();

                    //Required to read input for loop to continue
                    if (answer == "y")
                    {
                        askAgain = false;
                        keepGoing = true;
                        Console.WriteLine();
                    }

                    else if (answer == "n")
                    {
                        askAgain = false;
                        keepGoing = false;
                        Console.WriteLine("Thanks for the help!");

                    }
                    else
                    {
                        askAgain = true;
                        Console.WriteLine("I'm sorry. I didn't understand that...Try again.");
                    }
                }
            } while (keepGoing);

            
        }
    }
    
}
