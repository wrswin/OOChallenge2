using System;

namespace OOChallenge2.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            while(true) {
                Console.WriteLine("1. Create Square");
                Console.WriteLine("2. Create Rectangle");
                Console.WriteLine("3. Create Equilateral Triangle");
                Console.WriteLine("4. Create Right Angle Triangle");
                Console.WriteLine("5. Create Circle");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");

                var choiceText = Console.ReadLine();

                int choice;
                try {
                    choice = int.Parse(choiceText);
                } catch(FormatException) {
                    Console.WriteLine("Please enter a number");

                    continue;
                }

                switch(choice) {
                    case 1: {
                        Console.Write("Enter colour: ");
                        var colour = Console.ReadLine();

                        var sideLength1 = RetrieveLength("size");

                        var square = new Square(sideLength1);
                        square.Colour = colour;

                        Console.WriteLine("Successfully created a Square");
                    } break;

                    case 2: {
                        Console.Write("Enter colour: ");
                        var colour = Console.ReadLine();

                        var sideLength1 = RetrieveLength("first side length");
                        var sideLength2 = RetrieveLength("second side length");

                        var rectangle = new Rectangle(sideLength1, sideLength2);
                        rectangle.Colour = colour;

                        Console.WriteLine("Successfully created a Rectangle");
                    } break;

                    case 3: {
                        Console.Write("Enter colour: ");
                        var colour = Console.ReadLine();

                        var sideLength1 = RetrieveLength("side length");

                        var equilateral = new Equilateral(sideLength1);
                        equilateral.Colour = colour;

                        Console.WriteLine("Successfully created an Equilateral Triangle");
                    } break;

                    case 4: {
                        Console.Write("Enter colour: ");
                        var colour = Console.ReadLine();

                        var sideLength1 = RetrieveLength("first side length");
                        var sideLength2 = RetrieveLength("second side length");

                        var rightAngle = new RightAngle(sideLength1, sideLength2);
                        rightAngle.Colour = colour;

                        Console.WriteLine("Successfully created a Right Angle Triangle");
                    } break;

                    case 5: {
                        Console.Write("Enter colour: ");
                        var colour = Console.ReadLine();

                        var radius = RetrieveLength("radius");

                        var circle = new Circle();
                        circle.Radius = radius;
                        circle.Colour = colour;

                        Console.WriteLine("Successfully created a Circle");
                    } break;

                    case 6: {
                        return;
                    } break;

                    default: {
                        Console.WriteLine($"Option {choice} not found");
                    } break;
                }
            }
        }

        /// <summary>
        ///  Retrieve a valid length from the user via the command line.
        ///  A valid length is defined as a positive whole number.
        /// </summary>
        static double RetrieveLength(string name) {
            while(true) {
                Console.Write($"Enter {name}: ");

                var text = Console.ReadLine();

                double length;
                try {
                    length = double.Parse(text);

                    if(Math.Truncate(length) != length) {
                        throw new DecimalLengthException();
                    }
                } catch(FormatException) {
                    Console.WriteLine("Please enter a number");

                    continue;
                } catch(DecimalLengthException) {
                    Console.WriteLine("Please enter a whole number");

                    continue;
                }

                if(length < 1) {
                    Console.WriteLine("Please enter a positive number");

                    continue;
                }

                return length;
            }
        }
    }
}