using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50 - DONE
            int[] numberArray = new int[50];
            
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50 - DONE
           
            Populater(numberArray);
            


            //TODO: Print the first number of the array - DONE
            Console.WriteLine("This is the first number of the array");
            Console.WriteLine(numberArray[0]);
            Console.WriteLine();

            //TODO: Print the last number of the array - DONE
            Console.WriteLine("This is the last number of the array");
            Console.WriteLine(numberArray[numberArray.Length - 1]);
            Console.WriteLine();

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); - DONE 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numberArray);
            NumberPrinter(numberArray);
            Array.Reverse(numberArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");//Didn't work, come back to this.... JK it worked!!!!
            ReverseArray(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers - DONE
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now - DONE
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List - DONE
            var numberList = new List<int>();

            //TODO: Print the capacity of the list to the console - DONE
            Console.WriteLine("numberList Capacity:");
            Console.WriteLine(numberList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this  - DONE          
            Populater(numberList);

            //TODO: Print the new capacity - DONE
            Console.WriteLine("numberList New Capacity:");
            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");
            
            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that! - DONE
            Console.WriteLine("What number will you search for in the number list?");           
            bool trueCheck = int.TryParse(Console.ReadLine(), out int userInput);
            NumberChecker(numberList, userInput);           
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            //NumberPrinter(numberList);  
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }  

        private static void OddKiller(List<int> numberList)
        {
            foreach (var item in numberList)
            {
                if (numberList[item] % 2 != 0)
                {
                    numberList.Remove(numberList[item]);
                }
            }
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        { 
            foreach (int number in numberList)
            {
                if (number == searchNumber)
                {
                    Console.WriteLine("Number is present");
                }
                else
                {
                    Console.WriteLine("Number not found");
                }
            }             
             
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i <= 50; i++)
            {
                numberList.Add(rng.Next(51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i]= rng.Next(51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
