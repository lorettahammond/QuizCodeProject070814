using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sports = { "racing", "baseball", "football", "basketball", "skiing", "tennis", "volleyball", "cycling"};

            string firstSports = sports.First();
            string secondSports = sports.Second();
            string thridSports = sports.Third();
            string fourthSports = sports.Fourth();
            string fifthSports = sports.Fifth();
        }
    }
}

//Write a LINQ Query that Returns The first 5 elements in an input sequence.