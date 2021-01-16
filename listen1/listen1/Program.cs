using System;


namespace listen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = MyArray();
            AllAlimentArray(array);
            int max = GetMaxAlement(array);
            int min = GetMinAlement(array);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
        static int[] MyArray()
        {
            int[] array = new int[] { 2, 12, 32, 34, 4, 7, 9, 6, 45, 554 };
            return array;
        }
        static int GetMaxAlement(int [] array)
        {
            int max = array[0];
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int GetMinAlement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void AllAlimentArray(int[] array)
        {
            Console.WriteLine("элементы массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("\nотдаю Корабах армянам");
        }
    }

    
}
