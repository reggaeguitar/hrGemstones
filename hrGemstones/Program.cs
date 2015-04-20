namespace hrGemstones
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numCases = Int32.Parse(Console.ReadLine());
            var numCasesCopy = numCases;
            var arr = new int[26];
            while (numCasesCopy-- > 0)
            {
                var line = Console.ReadLine();
                foreach (var ch in line.Distinct())
                {
                    ++arr[ch - 'a'];
                }
            }
            Console.WriteLine(arr.Where(x => x == numCases).Count());
        }
    }
}
