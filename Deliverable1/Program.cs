using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Welcome! I'm your friendly MilHip Conversion Bot!");

            string again;
            do
            {

                string dispUnit = "";
                Console.WriteLine(" ");

                Console.WriteLine("Please enter your measurement unit.");
                string userUnit = Console.ReadLine();

                Console.WriteLine(" ");
                Console.WriteLine("Thanks!  Please enter the amount of '" + userUnit + "' you'd like to convert.");
                double value = double.Parse(Console.ReadLine());

                Console.WriteLine("Fantastic!  Let me convert that to MilHip for you...");
                Console.WriteLine(" ");

                if (userUnit.ToLower().StartsWith("inch"))
                {
                    value *= 3.5;

                    if (value != 1)
                    {
                        dispUnit = " fidget spinners";
                    }
                    else
                    {
                        dispUnit = " fidget spinner";
                    }
                }

                else if (userUnit.ToLower() == "feet" || userUnit.ToLower() == "foot")
                {
                    value *= 5;

                    if (value != 1)
                    {
                        dispUnit = " memes";
                    }
                    else
                    {
                        dispUnit = " meme";
                    }

                }

                else if (userUnit.ToLower().StartsWith("fidget spinner"))
                {
                    value /= 3.5;

                    if (value != 1)
                    {
                        dispUnit = " inches";
                    }
                    else
                    {
                        dispUnit = " inch";
                    }
                }

                else if (userUnit.ToLower().StartsWith("meme"))
                {
                    value /= 5;

                    if (value != 1)
                    {
                        dispUnit = " feet";
                    }
                    else
                    {
                        dispUnit = " foot";
                    }
                }

                else
                {
                    Console.WriteLine("You have not entered a valid measurement.");
                }


                Console.WriteLine("You have " + value + dispUnit);
                Console.WriteLine(" ");
                Console.Write("Would you like to make another conversion?");
                Console.WriteLine(" ");

                again = Console.ReadLine();
            } while (String.Equals(again, "yes", StringComparison.OrdinalIgnoreCase));

        }

    }
}
