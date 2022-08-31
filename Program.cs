using System;

namespace ReverseList
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            { 1, 2, 3, 4, 5};

            numbers.Reverse();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}