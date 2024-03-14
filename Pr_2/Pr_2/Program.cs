using System;


namespace Pr_2
{
    class Pr2
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
        }

        //Task1
        private static void Task1()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (int elem in numbers)
            {
                if (elem >= 1 && elem <= 10 + 2)
                {
                    Console.WriteLine($"Element {elem} is in range [1,12]");
                }
            }
        }

        //Task2
        private static void Task2()
        {
            Console.Write("First side of the triangle: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Second side of the triangle: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Third side of the triangle: ");
            int side3 = int.Parse(Console.ReadLine());

            if (IsTriangleExist(side1, side2, side3))
            {
                Console.Write("Type of triangle: ");
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("With different sides");
                }
                int perimeter = FindPerimeter(side1, side2, side3);
                double square = FindSquare(side1, side2, side3);

                Console.WriteLine($"P: {perimeter}\nS: {square}");
            }
            else
            {
                Console.WriteLine("Triangle doesn't exist");
            }

        }

        private static bool IsTriangleExist(int side1, int side2, int side3)
        {
            return side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2;
        }
        private static int FindPerimeter(int side1, int side2, int side3)
        {
            return side1 + side2 + side3;
        }
        private static double FindSquare(int side1, int side2, int side3)
        {
            double p = (side1 + side2 + side3) / 2;
            double result = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            return result;
        }

        //Task3
        private static void Task3()
        {
            int[] X = new int[10 + 2];

            Random random = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-100, 100);
            }

            double min, max;
            max = double.NegativeInfinity;
            min = double.PositiveInfinity;

            foreach (int num in X)
            {
                if (num < min)
                {
                    min = num;
                }
                else if (num > max)
                {
                    max = num;
                }
            }

            foreach (int num in X)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"\nMin: {min}\nMax: {max}");
        }


        //Task4 
        private static void Task4()
        {
            int[] X = new int[10 + 2];

            X[0] = 0;

            Console.Write("Enter the value of M: ");
            int M = int.Parse(Console.ReadLine());

            List<int> Y = new List<int>();

            Random random = new Random();
            for (int i = 1; i < X.Length; i++)
            {
                X[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Array X\n:");
            PrintArray(X);

            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    Y.Add(num);
                }
            }

            Console.WriteLine("\nArray Y:\n");
            PrintArray(Y.ToArray());
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
