using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your first name: ");
            string name = Console.ReadLine();
            Console.Write("Year born: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month born: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day born: ");
            int day = int.Parse(Console.ReadLine());
            DateTime _birthDate = new DateTime(year, month, day);
            DateTime _today = DateTime.Today;
            DateTime _nextBirthday = new DateTime(_today.Year, month, day);
            TimeSpan Age = _today - _birthDate;
            TimeSpan nextBirthday = _nextBirthday - _today;
            DateTime _hundred = new DateTime((year + 100), month, day);
            var nextbirthday1 = nextBirthday.Days % 365;
            if (nextbirthday1 < 1)
            {
                nextbirthday1 += 365;
            }

            Console.Clear();

            Console.WriteLine("Hi! " + name);
            Console.WriteLine("Your age: {0} years and {1} days", (int)(Age.Days / 365.25), (int)(Age.Days % 365.25));
            Console.WriteLine("Your next birtday is in {0} days", nextbirthday1);
            Console.WriteLine("Your hundred birthday will be on a " + _hundred.DayOfWeek);
            Console.ReadKey();


        }
    }
}
