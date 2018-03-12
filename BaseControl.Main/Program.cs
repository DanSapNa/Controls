using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaseControl.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> splittedList = new List<string>();
            List<int> amountOfPeople = new List<int>();
            List<string> cities = new List<string>();
            string pattern = @"";

            Console.WriteLine("Enter list of the cities with population splitted by comma. \n\tExample: Kharkiv=1431000,Kiev=2804000,Las Vegas=603400");
            Console.Write("\n\tInput a string: ");
            //string inputString = "Kharkiv=1431000,Kiev=2804000,Las Vegas=603400";
            string inputString = Console.ReadLine();

            //if (string.IsNullOrEmpty(pattern))
            //{
            //    return;
            //}

            //try
            //{
            //    Regex.Match(inputString, pattern);
            //}
            //catch (ArgumentException)
            //{
            //    return;
            //}

            splittedList = inputString.Split(',').ToList();

            foreach (var text in splittedList)
            {
                cities.Add(text.Split('=')[0]);
                amountOfPeople.Add(Int32.Parse(text.Split('=')[1]));
            }

            Console.WriteLine($"\nMost populated: {cities[amountOfPeople.IndexOf(amountOfPeople.Max())]} ({amountOfPeople.Max()} people)");
            Console.WriteLine($"Longest name: {cities.OrderByDescending(x=>x.Length).First()}({cities.Max(s => s.Length)} letters)");

            Console.ReadKey();
        }
    }
}
