using System;

namespace hand_in_one
{
    class Program
    {
         private static void RunExerciseOne()
            {
                var firstName = "John";
                var lastName = "Doe";
                Console.WriteLine("You successfully ran exercise one!");
                Console.WriteLine($"Hello {firstName} {lastName}! I´m glad to inform you that you are the test subject of my very first assignment!");
            }

          private static void RunExerciseTwo()
            {
                var todaysDate = DateTime.Now;
                var yesterdaysDate = todaysDate.AddDays(-1);
                var tomorrowsDate = todaysDate.AddDays(1);

                Console.WriteLine("You successfully ran exercise two!");
                Console.WriteLine($"Todays date is {todaysDate}");
                Console.WriteLine($"Tomorrows date is {tomorrowsDate}");
                Console.WriteLine($"Yesterdays date was {yesterdaysDate}");
            }

              private static void RunExerciseThree()
            {
                Console.WriteLine("Enter your first name:");
                var firstNameChoice = (Console.ReadLine() ?? "");
                Console.WriteLine("Enter your last name:");
                var lastNameChoice = (Console.ReadLine() ?? "");
                Console.Write($"{firstNameChoice} {lastNameChoice} ");
            }

            private static void RunExerciseFour()
            {
                String str = "The quick fox Jumped Over the DOG";
                String newString = str.Replace("quick", "brown")
                                        .Replace(str.Substring(str.IndexOf("J"), 19), "jumped")
                                            .Insert(20, " over the lazy dog");
                Console.WriteLine(newString);
            }

            private static void RunExerciseFive()
            {
                String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
                String newString = str.Remove(-5, 2);
                Console.WriteLine(newString);
            }
    
        static void Main(string[] args)
        {
           

        var keepAlive = true;
        while(keepAlive)
        {
            try
            {
                Console.Write("Enter assignment number (or -1 to exit): ");
                var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                Console.ForegroundColor = ConsoleColor.Green;
                switch (assignmentChoice)
                {
                    case 1:
                        RunExerciseOne();
                        break;
                    case 2:
                        RunExerciseTwo();
                        break;
                    case 3:
                        RunExerciseThree();
                        break;
                    case 4:
                        RunExerciseFour();
                        break;
                    case 5:
                        RunExerciseFive();
                        break;
                    case -1:
                        keepAlive = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid assignment number!");
                        break;
                }
                Console.ResetColor();
                Console.WriteLine("Hit any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not a valid assignment number!");
                Console.ResetColor();
            }
        }
        }
    }
}
