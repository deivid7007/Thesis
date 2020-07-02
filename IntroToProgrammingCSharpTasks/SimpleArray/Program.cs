using System;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            Console.Write("Enter number of elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] simpleArray = new int[numberOfElements];
            InputArray(simpleArray);

            do
            {
                Console.WriteLine("Choose a command (swap, increase, decrease or info) or type 'End' if you want to exit:");
                command = Console.ReadLine();

                switch (command)
                {
                    case "swap":
                        SwapElementsInArray(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "increase":
                        IncreaseArrayElementsUsingString(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "decrease":
                        DecreaseArrayElementsUsingNumber(simpleArray);
                        OutputArray(simpleArray);
                        break;
                    case "info":
                        ArrayInfo(simpleArray);
                        OutputArray(simpleArray);
                        break;
                }
            } while (command != "End");

            OutputArray(simpleArray);
        }

        static void InputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + arr[i]);
            }
        }

        static void SwapElementsInArray(int[] arr)
        {
            int index1 = 0;
            int index2 = 0;
            int numberSwap = 0;

            bool index1IsNumber = false;
            bool index2IsNumber = false;

            string indexes;

            while (!index1IsNumber || !index2IsNumber)
            {
                Console.WriteLine("Enter the indexes of the two elements you want to swap (seperate them with a space): ");
                indexes = Console.ReadLine();
                if (!indexes.Contains(" "))
                {
                    Console.WriteLine("Input must contain only one space!!");
                    continue;
                }

                index1IsNumber = int.TryParse(indexes.Substring(0, indexes.IndexOf(" ")), out index1);
                index2IsNumber = int.TryParse(indexes.Substring(indexes.IndexOf(" ")), out index2);

                if (index1 > arr.Length || index2 > arr.Length)
                {
                    Console.WriteLine("The input numbers were greater than the length of the array!");
                    index1IsNumber = false;
                    index2IsNumber = false;
                }
            }

            numberSwap = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = numberSwap;
        }

        static void IncreaseArrayElementsUsingString(int[] arr)
        {
            int charSum = 0;

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            foreach (char c in word)
            {
                Console.WriteLine($"{c} --> {(int)c}");
                charSum += c;
            }

            Console.WriteLine("Total sum: " + charSum);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += charSum;
            }
        }

        static void DecreaseArrayElementsUsingNumber(int[] arr)
        {
            bool inputIsNumber = false;
            int number = 0;

            while (!inputIsNumber)
            {
                Console.WriteLine("Enter a number: ");
                inputIsNumber = int.TryParse(Console.ReadLine(), out number);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= number;
            }
        }

        static void ArrayInfo(int[] arr)
        {
            int arraySum = 0;
            int greatestArrayElement = arr[0];
            int leastArrayElement = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > greatestArrayElement)
                {
                    greatestArrayElement = arr[i];
                }

                if (arr[i] < leastArrayElement)
                {
                    leastArrayElement = arr[i];
                }

                arraySum += arr[i];
            }

            Console.WriteLine("Array count --> " + arr.Length);
            Console.WriteLine("Max element --> " + greatestArrayElement);
            Console.WriteLine("Min element --> " + leastArrayElement);
            Console.WriteLine("Total sum --> " + arraySum);
        }
    }
}
