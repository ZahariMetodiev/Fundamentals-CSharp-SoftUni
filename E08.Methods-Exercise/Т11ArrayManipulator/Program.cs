using System;
using System.Linq;

namespace Т11ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(array, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        int result = MaxEven(array);

                        if (result == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if (command[1] == "odd")
                    {
                        int result = MaxOdd(array);

                        if (result == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        int result = MinEven(array);
                        
                        if (result == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if(command[1] == "odd")
                    {
                        int result = MinOdd(array);

                        if (result == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        FyrstEven(array, count);
                    }
                    else if(command[2] == "odd")
                    {
                        FyrstOdd(array, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);

                    if (command[2] == "even")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            LastEven(array, count);
                        }
                    }
                    else if(command[2] == "odd")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            LastOdd(array, count);
                        }
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static void Exchange(int[] array, int index)
        {
            int[] fyrstArr = new int[array.Length - index - 1];
            int[] secondArr = new int[index + 1];

            int fyrstArrCounter = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                fyrstArr[fyrstArrCounter] = array[i];
                fyrstArrCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = array[i];
            }

            for (int i = 0; i < fyrstArr.Length; i++)
            {
                array[i] = fyrstArr[i];
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                array[fyrstArr.Length + i] = secondArr[i];
            }
        }

        static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void FyrstEven(int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] numbers = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            }
        }

        static void FyrstOdd(int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] numbers = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            }
        }

        static void LastEven(int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] numbers = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            }
        }

        static void LastOdd(int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] numbers = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", " , numbers) + "]");
            }
        }


    }
}
