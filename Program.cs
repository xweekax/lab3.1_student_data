using System;

namespace lab3._1_student_info
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Jeff", "Steve", "Frank" };
            string[] candy = { "Snickers", "Lemon Drop", "Whatchamacallit" };
            string[] title = { "Hellraiser", "Clown", "Mime" };
            string candyTitle;            
            bool repeat = false;

            Console.WriteLine("Which student would you like to learn about (enter 1-3, or 4 for student list)");
            string choice = Console.ReadLine();
            int namesNumber = int.Parse(choice);
            int index = namesNumber - 1;
            int candyChoice = namesNumber - 1;
            int titleChoice = namesNumber - 1;

            do
            {
                if (namesNumber == 1 || namesNumber == 2 || namesNumber == 3)
                {
                    Console.WriteLine($"You have chosen {names[index]}");
                    Console.WriteLine("Would you like to know their favorite Candy or Title?");
                    Console.WriteLine("Please enter 'candy' or 'title'");
                    candyTitle = Console.ReadLine();
                    candyTitle.ToLower();

                    if (candyTitle == "candy")
                    {
                        Console.WriteLine($"{names[index]} favorite candy is {candy[candyChoice]}");
                        repeat = false;
                    }
                    else if (candyTitle == "title")
                    {
                        Console.WriteLine($"{names[index]} previous title is {title[titleChoice]}");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("You have entered invalid information please try again");
                        Console.WriteLine("");
                        repeat = true;
                    }                    
                }
                else if (namesNumber == 4)
                {
                    Console.WriteLine($"The list of students is: {names[0]}, {names[1]} and {names[2]}");
                }
                else
                {
                    Console.WriteLine("This is invalid input try again");
                    Main();
                }
            } while (repeat == true);

            redo();

            static void redo()
            {
                string repeatChoice;

                Console.WriteLine("Would you like to learn more about another studen? (yes or no)");
                repeatChoice = Console.ReadLine();
                repeatChoice.ToLower();
                if (repeatChoice == "yes")
                {
                    Console.Clear();
                    Main();
                }
                else if (repeatChoice == "no")
                {
                    Console.WriteLine("Thanks for playing");
                }
            }

        }

    }
}
