using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMovieStart
{
    public class MovieStar
    {
        private DateTime dateOfBirth;
        private string name;
        private string surname;
        private string sex;
        private string nationality;

        public MovieStar()
        {
           
        }

        public DateTime DateOfBirth { get => dateOfBirth; set { dateOfBirth = value; } }
        public string Name { get => name;  set { name = value; } }
        public string Surname { get => surname; set { surname = value; } }
        public string Sex { get => sex; set { sex = value; } }
        public string Nationality { get => nationality; set  { nationality = value; } }
        
    }
}
