using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MethodsWithLoopsandConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRankings();

            PauseConsole();

            RankingsByThree();

            PauseConsole();
            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();

            bool areTheseEqual = CheckForEqual(userNum1, userNum2);

            Console.WriteLine($"{userNum1} is equal to {userNum2}: {areTheseEqual}");

            PauseConsole();
            EvenOrOddNumber(userNum2);

            PauseConsole();
            userNum1 = GetUserNumber();
            PositiveOrNegative(userNum1);

            PauseConsole();
            Console.WriteLine("Tell us your age and we'll tell you if you can vote.");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Could not compute, try again.");

            EligibleAgeToVote(age);

            int userNumber = GetUserNumber();
            CheckingRange(userNumber);

            int userNumber2 = GetUserNumber();
            int multiplyTo = GetUserNumber();
            MultiplyTable(userNumber2, multiplyTo);

            int userNumber3 = GetUserNumber();
            int[] randomNumbers = IndicesofArray(userNumber3);
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            int sumOfElements = SumOfArray(randomNumbers);
            Console.WriteLine($"The sum of integers in the array = {sumOfElements}.");

            PauseConsole();

            userNumber = GetUserNumber();

            CubeUp(userNumber);
        }

        private static void CubeUp(int CubeTo)
        {
            double cubed = 0;

            for (int i = 1; i < CubeTo; i++)
            {
                cubed = Math.Pow(i, 3);
                Console.WriteLine($"Number {i} is the cube of {i} is {cubed}");
            }
        }

        private static int SumOfArray(int[] randomNumbers)
        {
            int sum = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                sum += randomNumbers[i];
            }
            return sum;
        }

        private static int[] IndicesofArray(int userNumber3)
        {
            int[] randos = new int[userNumber3];

            Random rng = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = rng.Next(501);
            }
            return randos;
        }

        private static void MultiplyTable(int userNumber2, int multiplyTo)
        {
            int product = 0;

            for (int i = 1; i <= multiplyTo; i++)
            {
                product = userNumber2 * i;
                Console.WriteLine($"{userNumber2} * {i} = {product}");
            }
        }

        private static void CheckingRange(int userNumber)
        {
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is within range!");    
            }
            else 
            {
                Console.WriteLine("You're out of bounds!");
            }
        }   
        private static void EligibleAgeToVote(int userAge)
        {
            if (userAge >= 18)
            {
                Console.WriteLine("You are eligible to vote!");
            }
            else
            {
                Console.WriteLine("You are ineligible to vote.");
            }
        }

        private static void PositiveOrNegative(int num1) 
        {
            if (num1 > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }
        }

        private static void EvenOrOddNumber(int userNumber)
        {
            if (userNumber == 11)
            {
                Console.WriteLine($"{userNumber} is odd.");
            }    
        }


        private static int GetUserNumber()
        {
            Console.Write("What's your number: ");
            int userNum = int.Parse(Console.ReadLine());

            return userNum;
        }

        private static bool CheckForEqual (int num1, int num2)
        {
            return num1 == num2;
        }

        private static void RankingsByThree()
        {
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }

        private static void PlayerRankings()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        private static void PauseConsole() 
            {
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine();    
            }
        }
        }

