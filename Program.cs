using System;
using System.Linq;

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
                string firstName = GetFirstName();
                
                string lastName = GetLastName();
                Console.WriteLine($"{firstName} {lastName}");
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
                String newString = str.Substring(str.IndexOf("["), 11)
                                        .Remove(2, 4)
                                            .Insert(6, ",6,7,8,9,10");
                Console.WriteLine(newString);
            }

            private static void RunExerciseSix()
            {
                double num1 = PickNumber();
                double num2 = PickNumber();

                if(num1 > num2)
                {
                    Console.WriteLine("Number {0} is the biggest", num1);
                } else
                  {
                      Console.WriteLine("Number {0} is the biggest", num2);
                  }
                
                Console.WriteLine($"The result: {num1} - {num2} = " + RunSubtraction(num1, num2));

                Console.WriteLine($"The result: {num1} + {num2} = " + RunAddition(num1, num2));

                Console.WriteLine($"The result: {num1} * {num2} = " + RunMultiplication(num1, num2));

                Console.WriteLine($"The result: {num1} / {num2} = " + RunDivision(num1, num2));
            }

            static void RunExerciseSeven()
            {
                Console.WriteLine("Pick a radius");
                double num = PickNumber();
                
                Console.WriteLine($"The radius with your chosen number: {num} will give a circle area = " + RunCircleArea(num));
                
                Console.WriteLine($"The radius with your chosen number: {num} will give a circle volume = " + RunCircleVolume(num));
            }

            static void RunExerciseEight()
            {
                double num = PickNumber();
                
                Console.WriteLine($"The square root of your chosen number: {num} = " + RunSquareRoot(num));
                
                Console.WriteLine($"The result of your chosen number: {num} raised to the power of 2 = " + RunPowerOfTwo(num));

                Console.WriteLine($"The result of your chosen number: {num} raised to the power of 10 = " + RunPowerOfTen(num));
            }

            static void RunExerciseNine()
            {
               string firstName = GetFirstName();
               string lastName = GetLastName();
               string fullName = firstName + " " + lastName;

               Console.WriteLine($"Hello {fullName}, what is you birth year?");

               bool keepLooping = true;

               while(keepLooping)
               {
                   int birthYear = GetBirthYear();

                   keepLooping = false;

                   if(birthYear >= 1920 && birthYear <= 2020)
                   {
                       int userAge = DateTime.Now.Year - birthYear;
                       Console.WriteLine("You have the age.");
                            if(userAge >= 18)
                            {
                                Console.WriteLine("Would you like to order a beer (y/n)?");
                                string beerOrNot = Console.ReadLine();
                                    if(beerOrNot == "y")
                                    {
                                        Console.WriteLine("A beer is coming up.");
                                    } else if(beerOrNot == "n")
                                        {
                                            Console.WriteLine("Would you like a coke (y/n)?");
                                            string cokeOrNot = Console.ReadLine();
                                            if(cokeOrNot == "y")
                                            {
                                                Console.WriteLine("A coke is coming up.");
                                            } else if(cokeOrNot == "n")
                                                {
                                                    Console.WriteLine("Sorry, no order options are available.");
                                                }
                                            else
                                            {
                                                Console.WriteLine("That is not a valid option.");
                                            }
                                        }
                                    else
                                    {
                                        Console.WriteLine("That is not a valid option.");
                                    }
                            } else
                            {
                                Console.WriteLine("Would you like a coke (y/n)?");
                                string cokeOrNot = Console.ReadLine();
                                if(cokeOrNot == "y")
                                {
                                    Console.WriteLine("A coke is coming up.");
                                } else if(cokeOrNot == "n")
                                        {
                                            Console.WriteLine("Sorry, no order options are available.");
                                        }
                                    else
                                    {
                                        Console.WriteLine("That is not a valid option.");
                                    }
                            }
                    }   else 
                        {
                        Console.WriteLine("That is not a valid birthyear.");
                        keepLooping = true;
                        }   
                } 
            }

            static void RunExerciseTen()
            {
                Console.WriteLine("Please choose an option: 1, 2 or 3");
                var optionChoice = int.Parse(Console.ReadLine() ?? "");
                
                switch (optionChoice)
                {
                    case 1:
                        
                        bool keepLooping = true;
                        while(keepLooping)
                        {
                            var a = PickNumber();
                            var b = PickNumber();

                            keepLooping = false;

                            if(b == 0)
                            {
                                Console.WriteLine("0 is not an option!");

                                keepLooping = true;
                            } else
                            {
                                Console.WriteLine($"The result: {a} / {b} = " + RunDivision(a, b));
                            }
                        }
                        break;
                    case 2:
                        RunExerciseFour();
                        break;
                    case 3:
                        ChangeTextColor();
                        break;
                    default:

                    break;
                }
            }

            static void RunExerciseEleven()
            {
                bool keepLooping = true;
                while(keepLooping)
                {
                    var numberChoice = PickNumber();

                    keepLooping = false;
                    if (numberChoice !< 0)
                    {
                        Console.WriteLine("Error! Number is less or equal to zero.");
                        keepLooping = true;
                    } else
                    {
                        for(var i = 0; i <= numberChoice; i++)
                        {
                            if(i % 2 == 0)
                            {
                                TextToRed();
                            } else
                            {
                                TextToGreen();
                            }

                            Console.WriteLine(i);
                        }
                        Console.WriteLine("-----------------------");
                        for(var i = numberChoice; i >= 0; i--)
                        {
                            if(i % 2 == 0)
                            {
                                TextToRed();
                            } else
                            {
                                TextToGreen();
                            }

                            Console.WriteLine(i);
                        }
                    }

                }
            }

            static void RunExerciseTwelve()
            {
                
                for(var i = 1; i <= 10; i++)
                {
                    for(var j = 1; j <= 10; j++)
                    {
                        Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                    }
                    Console.WriteLine();
                }
            }

            static void RunExerciseThirteen()
            {
                var counter = 0;
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 500);
                Console.WriteLine("Guess a number from 1-500.");

                bool keepLooping = true;
                while(keepLooping)
                {
                    var numberChoice = PickNumber();
                    keepLooping = false;
                    if(randomNumber == numberChoice)
                    {
                        counter++;
                        Console.WriteLine($"You hit the right number on {counter} tries!");
                    } else if(numberChoice < randomNumber)
                    {
                        counter++;
                        Console.WriteLine($"Your guess was too small. Number of guesses: {counter}");
                        keepLooping = true;
                    } else 
                    {
                        counter++;
                        Console.WriteLine($"Your guess was too big. Number of guesses: {counter}");
                        keepLooping = true;
                    }
                }
            }

            static void RunExerciseFourteen()
            {
                double sum = 0;
                double average = 0;
                var counter = 0;

                Console.WriteLine("Pick a number from 0-infinity. Pick number -1 to get the sum and average of your number choices.");

                bool keepLooping = true;
                while(keepLooping)
                {
                    var numberChoice = PickNumber();
                    keepLooping = false;
                    if(numberChoice > -1)
                    {
                        counter++;
                        sum += numberChoice;
                        average = sum / counter;
                        keepLooping = true;

                    } else if(numberChoice == -1)
                    {
                        Console.WriteLine("Sum: {0}", sum);
                        Console.WriteLine("Average: {0}", average);
                    } else
                    {
                        Console.WriteLine("Not a valid entry.");
                        keepLooping = true;
                    }
                }

            }

            static void RunExerciseEighteen()
            {
                var array = RandomIntNumbers();
                //Console.WriteLine(String.Join(" ", array));

                foreach(int number in array)
                {
                    Console.Write(number + " ");
                }
                
                Console.WriteLine();

                var doubleArray = IntToDoubleArray(array);
                //Console.WriteLine(String.Join(" ", doubleArray));

                foreach(double number in doubleArray)
                {
                    if(Double.IsInfinity(number))
                    {
                        Console.Write("bull");
                    }
                    Console.WriteLine(number);
                }
            }

            static void RunExerciseNineteen()
            {
                int bill = RandomIntNumber();
                Console.WriteLine(bill);
                int sumToPay = UserSum(bill);
                int sumResult = SumResult(bill, sumToPay);
                Console.WriteLine(sumResult);
                int[] coins = IntArrayWithCoins();
                int[] coinsBack = new int[coins.Length];
                ReturnCoins(sumResult, coinsBack, coins);

                for(int i = 0; i < coins.Length; i++)
                {
                    Console.WriteLine(coins[i] + "x" + coinsBack[i]);
                }
            }

            static void RunExerciseTwentyone()
            {
                String userInput = AskUserInput();
                String[] splitString = SplitString(userInput);

                foreach(String value in splitString)
                {
                    Console.WriteLine(value);
                }
                
            }

            static String[] SplitString(String userInput)
            {
                String[] userInputStringArray = userInput.Split(new String[] {","}, StringSplitOptions.None);
                
                return userInputStringArray;
            }
            static String AskUserInput()
            {
                String userInput = new String(" ");
                Console.WriteLine("Please enter numbers separated by commas(,)");
                return userInput = Console.ReadLine();
            }

            static void ReturnCoins(int sumResult, int[] returnCoins, int[] coins)
            {
                for(int i = 0; i < coins.Length; i++)
                {
                    if(sumResult < coins[i])
                    {
                        returnCoins[i] = 0;
                    } else if((sumResult / coins[i]) > 0)
                    {
                        returnCoins[i] = (sumResult / coins[i]);
                        sumResult= (sumResult % coins[i]);
                    }
                }
            }
            

            static int SumResult(int bill, int sumToPay)
            {
                return sumToPay - bill;
            }

            static int[] IntArrayWithCoins()
            {
                int[] coins = new int[] {1000, 500, 100, 50, 20, 10, 5, 1};

                return coins;
            }
            static int UserSum(int bill)
            {
                int number = 0;
                
                bool keepLooping = true;
                while(keepLooping)
                {
                    Console.WriteLine("Enter the sum to pay: ");
                    bool numberIsNumber = int.TryParse(Console.ReadLine(), out number);
                    if(numberIsNumber && number > bill)
                    {
                        keepLooping = false;
                        return number;
                    } else if(number < bill)
                    {
                        Console.WriteLine("Entry is less than bill");
                        keepLooping = true;
                        continue;
                    } else
                    {
                        Console.WriteLine("Entry not a number!");
                        keepLooping = true;
                        continue;
                    }
                }
                return number;
            }

            static int RandomIntNumber()
            {
                int number = 0;
                Random randomNumber = new Random();

                return number = randomNumber.Next(500);
            }

            static double[] IntToDoubleArray(int[] value)
            {
                Double[] doubleArray = new Double[value.Length];
                for(int i = 0; i < value.Length; i++)
                {
                    doubleArray[i] = (Double)1 / value[i];
                }
                return doubleArray;
            }
            static int[] RandomIntNumbers()
            {
                int[] intArray = new int[10];
                Random randomNumbers = new Random();
                
                for(int i = 0; i < intArray.Length; i++)
                {
                    intArray[i] = randomNumbers.Next(0, 20);
                }
                return intArray;
            }
            static void ChangeTextColor()
            {
                var keepAlive = true;
                while(keepAlive)
                {
                    try
                    {
                        Console.WriteLine("Please choose a text color or exit");
                        Console.WriteLine("r - red\ng - green\ne - exit");
                        Console.Write("Your option? ");
                        var calculationChoice = (Console.ReadLine() ?? "");
                    switch (calculationChoice)
                    {
                        case "r":
                            TextToRed();
                            Console.WriteLine("The text is now red");
                            break;
                        case "g":
                            TextToGreen();
                            Console.WriteLine("The text is now green");
                            break;
                        case "e":
                            keepAlive = false;
                            break;
                        default:
                            Console.WriteLine("That is not a valid entry letter!");
                            break;
                    }
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                    }
                    catch
                    {
                        Console.WriteLine("That is not a valid letter!");
                    }
                }
            }
            static void TextToGreen()
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            static void TextToRed()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            static string GetFirstName()
            {
                string firstNameChoice = "";
                Console.WriteLine("Enter your first name:");
                return firstNameChoice = (Console.ReadLine() ?? "");
            }

            static string GetLastName()
            {
                string lastNameChoice = "";
                Console.WriteLine("Enter your last name:");
                return lastNameChoice = (Console.ReadLine() ?? "");
            }

            static int GetBirthYear()
            {
                int birthYear = 0;
                Console.WriteLine("Type your birth year, and press enter");
                return birthYear = int.Parse(Console.ReadLine());
            }

            static double PickNumber()
            {
               double num = 0;
               Console.WriteLine("Type a number, and press enter.");
               Console.Write("Your choice: ");
               return num = int.Parse(Console.ReadLine());
            } 

            static double RunSubtraction(double num1, double num2)
            {
                return num1 - num2;
            }

            static double RunAddition(double num1, double num2)
            {
                return num1 + num2;
            }

            static double RunMultiplication(double num1, double num2)
            {
                return num1 * num2;
            }

            static double RunDivision(double num1, double num2)
            {
                return num1 / num2;
            }

            static double RunCircleArea(double num)
            {
                return 2 * Math.PI * num * num;
            }

            static double RunCircleVolume(double num)
            {
                return (4 * Math.PI * num * num * num) / 3;
            }

            static double RunSquareRoot(double num)
            {
                return Math.Sqrt(num);
            }

            static double RunPowerOfTwo(double num)
            {
                return Math.Pow(num, 2);
            }

            static double RunPowerOfTen(double num)
            {
                return Math.Pow(num, 10);
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
                    case 6:
                        RunExerciseSix();
                        break;
                    case 7:
                        RunExerciseSeven();
                        break;
                    case 8:
                        RunExerciseEight();
                        break;
                    case 9:
                        RunExerciseNine();
                        break;
                    case 10:
                        RunExerciseTen();
                        break;
                    case 11:
                        RunExerciseEleven();
                        break;
                    case 12:
                        RunExerciseTwelve();
                        break;
                    case 13:
                        RunExerciseThirteen();
                        break;
                    case 14:
                        RunExerciseFourteen();
                        break;
                    case 18:
                        RunExerciseEighteen();
                        break;
                    case 19:
                        RunExerciseNineteen();
                        break;
                    case 21:
                        RunExerciseTwentyone();
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
                Console.WriteLine("That is not a valid entry");
                Console.ResetColor();
            }
        }
        }
    }
}
