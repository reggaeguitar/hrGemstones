namespace hrGemstones
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numCases = Int32.Parse(Console.ReadLine());
            var arr = new int[26];
            for (int i = 0; i < numCases; ++i)
                Console.ReadLine().Distinct().ToList().ForEach(x => ++arr[x - 'a']);
            Console.WriteLine(arr.Where(x => x == numCases).Count());
        }
    }
}
