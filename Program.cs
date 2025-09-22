namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfDuplicateNumberPresent(GetInputArray());
        }

        public static int[] GetInputArray()
        {
            Console.Write($"Total number of elements: ");
            int n = Convert.ToInt32( Console.ReadLine() );
            int[] array = new int[n];
            Console.WriteLine($"Input {n} number of elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i+1} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        public static bool IfDuplicateNumberPresent(int[] array)
        {
            if (array.GroupBy(x => x).Any(g => g.Count() > 1))
            {
                Console.WriteLine("Output: True");
                return true;
            }
            Console.WriteLine("Output: False");
            return false;
        }
    }
}
