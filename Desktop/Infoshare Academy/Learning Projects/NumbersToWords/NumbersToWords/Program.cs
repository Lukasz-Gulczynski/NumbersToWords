using System;
using System.Collections.Generic;

namespace NumbersToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordsDictionary();
        }

        static public void WordsDictionary()
        {
            Dictionary<int, string> wordsMap = new Dictionary<int, string>();
            wordsMap.Add(0, "");
            wordsMap.Add(1, "jeden");
            wordsMap.Add(2, "dwa");
            wordsMap.Add(3, "trzy");
            wordsMap.Add(4, "cztery");
            wordsMap.Add(5, "pięć");
            wordsMap.Add(6, "sześć");
            wordsMap.Add(7, "siedem");
            wordsMap.Add(8, "osiem");
            wordsMap.Add(9, "dziewięć");
            wordsMap.Add(10, "dziesięć");
            wordsMap.Add(11, "jedenaście");
            wordsMap.Add(12, "dwanaście");
            wordsMap.Add(13, "trzynaście");
            wordsMap.Add(14, "czternaście");
            wordsMap.Add(15, "piętnaście");
            wordsMap.Add(16, "szesnaście");
            wordsMap.Add(17, "siedemnaście");
            wordsMap.Add(18, "osiemnaście");
            wordsMap.Add(19, "dziewiętnaście");
            wordsMap.Add(20, "dwadzieścia");
            wordsMap.Add(30, "trzydzieści");
            wordsMap.Add(40, "czterdzieści");
            wordsMap.Add(50, "pięćdziesiąt");
            wordsMap.Add(60, "szcześćdziesiąt");
            wordsMap.Add(70, "siedemdziesiąt");
            wordsMap.Add(80, "osiemdziesiąt");
            wordsMap.Add(90, "dziewiędziesiąt");
            wordsMap.Add(100, "sto");
            wordsMap.Add(200, "dwieście");
            wordsMap.Add(300, "trzysta");
            wordsMap.Add(400, "czterysta");
            wordsMap.Add(500, "pięćset");
            wordsMap.Add(600, "szcześćset");
            wordsMap.Add(700, "siedemset");
            wordsMap.Add(800, "osiemset");
            wordsMap.Add(900, "dziewięćset");
            wordsMap.Add(1000, "tysiąc");
            wordsMap.Add(1000000, "milion");



            string words = "";

            Console.WriteLine("Wprowadź liczbę: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wprowadziłeś liczbę: {number}");
            if (number == 0)
            {
                words = "zero";
            }
            else if (number < 20)
            {
                words += wordsMap[number];
            }
            else if (number < 100)
            {
                words += wordsMap[number - (number % 10)] + " ";
                words += wordsMap[number % 10];               
            }
            else if (number < 1000)
            {
                words += wordsMap[number - (number % 10)] + " ";
                words += wordsMap[number % 100];
            }
            else if (number < 100000)
            {
                words += wordsMap[number % 1000];
            }
            Console.WriteLine("Liczba słownie: " + words);
            Console.ReadKey();
        }
    }
}
