using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            // x = 3;

            // Debug.WriteLine("Hello World!");
            //Debug.WriteLine(x);
            //Console.ReadLine();

            //double area;
            //int a, b, c, s;
            //int a= Convert.ToInt32(a);
            // a = 3;
            //b = 4;
            //c = 5;
            //s = (a + b + c) / 2;
            //area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //area = Convert.ToInt32(area);
            //Console.WriteLine("Enter number for a: " + a);
            //Console.WriteLine("Enter number for b: " + b);
            //Console.WriteLine("Enter number for c: " + c);
            //Console.WriteLine("Squareroot is: " + area);
            //Console.ReadLine();
            //int firstNumber = 42;
            //int secondNumber = 11;
            //int sum = firstNumber + secondNumber;
            //Console.WriteLine("Sum is: " + sum);
           

                // Output of a number to the user
                // Console.WriteLine(37);

                // Waiting for Enter
                // Console.ReadLine();

                // Output of a calculation
                // Console.WriteLine(1 + 1);

                // Waiting for Enter
                // Console.ReadLine();

                // Multiplication has greater priority
                //Console.WriteLine(1 + 2 * 3);
                //Console.WriteLine((1 + 2 )* 3);
                // waiting for Enter
                //Console.ReadLine();
                //Console.WriteLine("I have started to program in C#");
                //Console.WriteLine("I have started to program" + " in C#");

                // Multiline Output
                //Console.WriteLine("First line\r\nSecond line");

                // I prefer specifying "Enter" in more human form
                //Console.WriteLine("First line" + Environment.NewLine + "Second line");

                // Text containing a quote
                //Console.WriteLine("The letter started so sweet: \"My Darling\"");

                // Unicode characters, in this case beta
                //Console.WriteLine("If the font knows, here is Greek beta: \u03B2");
                // Console.WriteLine("Yes, and how many times" + Environment.NewLine + "can a man turn his head" + Environment.NewLine + "and pretend" + Environment.NewLine + "that he just doesn't see.");

                // Senior math test
                //Console.WriteLine("a) " + 1 + 1);
                /* Console.WriteLine("b) " + (1 + 1));
                Console.WriteLine("c) " + "mostly fun");*/

                // Declaration of variable to store text
                //string message;
                // Storing a value in prepared variable
                // message = " I can't live without you.";
                // Another variable(initialized with some value)
                //string anotherMessage = " I can't live without you.";
                // Output of variables
                //Console.WriteLine(message);
                //Console.WriteLine(anotherMessage);
                //int number = 2 + 1;
                //Console.WriteLine("Value of the variable: " + number);
                //int sum = 1 + 1;
                //Console.WriteLine("Answer to Senior math test" + Environment.NewLine + "One and one is: " + Environment.NewLine + sum);
                //int firstNumber = 42;
                //int secondNumber = 11;
                //int sum = firstNumber + secondNumber;
                //Console.WriteLine("Sum is: " + sum);
                // Two logical boolean variables
                //bool thePrettiestGirlLovesMe = true;
                //bool iAmHungry = false;
                //bool iAmNotHungry = !iAmHungry;
                //Console.WriteLine("She loves me: " + thePrettiestGirlLovesMe);
                //Console.WriteLine("I am hungry: " + iAmHungry);
                //Console.WriteLine("I am not hungry: " + iAmNotHungry);
                // DateTime now;
                //now = DateTime.Now;
                //Console.WriteLine("Now is " + now);
                //DateTime now = DateTime.Now;
                //int day = now.Day;
                //Console.WriteLine("Day is " + day);
                //Console.WriteLine("Device name: " + Environment.MachineName);
                //Console.WriteLine("Username: " + Environment.UserName);
                //DateTime today = DateTime.Today;
                //Console.WriteLine("Today is " + today.ToLongDateString());
                //DateTime today = DateTime.Today;
                //DateTime tomorrow = today.AddDays(1);
                //Console.WriteLine("I will continue learning on " + tomorrow.ToShortDateString() + ".");
                // Personal Practice Exercise
                //DateTime today = DateTime.Today;
                //DateTime nextweek = today.AddDays(7);
                //Console.WriteLine("Today" + ", " + today.ToShortDateString() + " is a good day.");
                //Console.WriteLine("A week from today," + nextweek.ToShortDateString() + " will be even better.");
                // Creating random number generator object
                //Random randomNumbers = new Random();
                // Repeatedly throwing a dice
                //int number1 = randomNumbers.Next(1, 7);
                //int number2 = randomNumbers.Next(1, 7);
                //int number3 = randomNumbers.Next(1, 6+1);
                // Output
                //Console.WriteLine("Thrown numbers: " + number1 + "," + number2 + "," + number3);
                // Writing number as number and converting to text
                // int number = 1234;
                //string numberAsText = number.ToString();
                //Console.WriteLine("Output of number: " + number);
                //Console.WriteLine("Output of text: " + numberAsText);
                // Prompting and accepting input from user
                //Console.Write("Enter a sentence (and press Enter): ");
                //string input = Console.ReadLine();
                //Console.WriteLine("You have entered: " + input);
                //Console.Write("How old are you?");
                //string input = Console.ReadLine();
                //int enteredNumber = Convert.ToInt32(input);
                //Console.WriteLine("Your age: " + enteredNumber);            
                //Console.Write("Enter year of birth: ");
                //string input = Console.ReadLine();
                //int yearOfBirth = Convert.ToInt32(input);
                //DateTime today = DateTime.Today;
                //int thisYear = today.Year;
                //int age = thisYear - yearOfBirth;
                //Console.Write("This year you are/will be: " + age);
                try
                {
                    Console.Write("Enter 1 number(press enter to continue: ");
                    string input1 = Console.ReadLine();
                    int number1 = Convert.ToInt32(input1);
                    Console.Write("Enter 2 number(press enter to continue: ");
                    string input2 = Console.ReadLine();
                    int number2 = Convert.ToInt32(input2);
                    int result = number1 + number2;
                    Console.Write("Sum of entered numbers is: " + result);
                }
                catch (Exception)
                {

                    Console.WriteLine("Incorrect input - cannot calculate");
                }

                Console.ReadLine();

                Console.WriteLine("Tim is a fine boy");
                Console.ReadLine();



            }
        }
}
