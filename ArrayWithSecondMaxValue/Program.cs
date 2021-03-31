using System;

namespace ArrayWithSecondMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsCount;
            Console.WriteLine("Введите количество элементов массива:");

            while (!int.TryParse(Console.ReadLine(), out elementsCount))
            {
                Console.WriteLine("Вы вводите не число!");
                Console.WriteLine("Введите количество элементов массива:");
            }

            int[] myFirstArray = new int[elementsCount];

            int secondMax;
            int max;

            for (int i = 0; i < myFirstArray.Length; i++)
            {
                Console.WriteLine($"Введите числовое значение элемента массива под индексом {i}");

                while (!int.TryParse(Console.ReadLine(), out myFirstArray[i]))
                {
                    Console.WriteLine("Вы вводите не число!");
                    Console.WriteLine($"Введите числовое значение элемента массива под индексом {i}");
                }
            }


            if (myFirstArray[0] > myFirstArray[1])
            {
                secondMax = myFirstArray[1];
                max = myFirstArray[0];
            }

            else
            {
                secondMax = myFirstArray[0];
                max = myFirstArray[1];
            }

            for (int i = 2; i < myFirstArray.Length; i++)
            {
                if (myFirstArray[i] >= max)
                {
                    secondMax = max;
                    max = myFirstArray[i];
                }

                else if (myFirstArray[i] > secondMax)
                {
                    secondMax = myFirstArray[i];
                }
            }

            Console.WriteLine("Второй наибольший элемент массива: " + secondMax);

            Console.ReadLine();
        }

    }
}
