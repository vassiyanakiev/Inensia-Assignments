using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleMovieStart
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = File.ReadAllText(@"D:\VisualStudioApps\ConsoleMovieStart\ConsoleMovieStart\Input.txt");

            List<MovieStar> movieStar = JsonConvert.DeserializeObject<List<MovieStar>>(input);
            
            foreach (var star in movieStar)
            {
                var today = DateTime.Today;

                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (star.DateOfBirth.Year * 100 + star.DateOfBirth.Month) * 100 + star.DateOfBirth.Day;

                var age = (a - b) / 10000;

                Console.WriteLine($"{star.Name} {star.Surname}\n{star.Sex}\n{star.Nationality}\n{age} years old");
                Console.WriteLine();
            }
        }
    }
}
