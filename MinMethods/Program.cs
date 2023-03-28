

namespace MinMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 8, 2 };
            Console.WriteLine(Min(array));
        }

        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }

}

