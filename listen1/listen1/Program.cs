using System;


namespace listen1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array2 = GetTwoAlement(MyArray());
            AllAlimentArray(array2);
        }
        static int[] MyArray()
        {
            int[] array = new int[] { 55, 32, 3, 34 };
            return array;
        }
        static int[] GetTwoAlement(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i]>array[j])
                    {
                        int element = array[i];
                        array[i] = array[j];
                        array[j] = element;
                    }
                }
            }
            return array;
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