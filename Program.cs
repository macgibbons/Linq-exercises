using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main (string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var fruitsThatStartWithL = fruits.Where (fruits =>
            {
                return fruits.StartsWith ("L");
            });

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> ()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var fourSixMultiples = numbers.Where (number =>
            {
                return number % 4 == 0 || number % 6 == 6;
            });

        }
    }
}