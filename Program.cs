 using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
           
            string[] friends = new string[2];
            friends[0] = "rosa";
            friends[1] = "mawiya";
            
            Console.WriteLine(numbers[2]);
            Console.WriteLine(friends[1]);
            Console.ReadLine();
        }
    }
}
