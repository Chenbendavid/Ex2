using Ex2.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadKey();
            //Sefi();
            //Chen();
            Female();
            //ExArray exArray = new ExArray();
            //exArray.StringWords();
            //exArray.StringWords2();
            //exArray.PeapleAndPlaces();  

        }

        public static void Sefi()
        {
            Console.WriteLine("Hello \r\nWorld:)");
            Console.WriteLine();
            Console.WriteLine("LOVE IS IN THE AIR!");
            string firstName = "Chen";
            string lastName = "Ben-David";
            String fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            Console.WriteLine("*****************************************************");

            string title = "*******ok, let's play!*******";


            Console.WriteLine(title.ToUpper());

            Console.Write("Insert your birth year > ");
            int birthYear = int.Parse(Console.ReadLine());
            int age = 2022 - birthYear;
            Console.WriteLine("your age is: " + age);
            Console.WriteLine("*****************************************************");
        }

        public static void Chen()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Your first name char is: " + name.First());
            Console.WriteLine("*****************************************************");

            Console.Write("Enter your Math grade > ");
            double mathGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter your Hebrow grade > ");
            double hebrowGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter your English grade > ");
            double englishGrade = double.Parse(Console.ReadLine());
            double average = (mathGrade + hebrowGrade + englishGrade) / 3;
            int rounded_average = (int)average;
            Console.WriteLine("Your schoole average is: " + average + ", But you can round it to: " + rounded_average);
            Console.WriteLine("*****************************************************");
        }

        public static void Female()
        {
            string firstN = "chen";
            string lastN = "Ben-David";
            var ageChen = 31;
            ageChen.ToString();
            Console.WriteLine(ageChen);
            string fullN = (firstN + lastN);
            Console.WriteLine(fullN.ToUpper() + (fullN.Count()));
            bool result = (fullN.Count()).Equals(ageChen);
            Console.WriteLine(result);
            Console.WriteLine("*****************************************************");


            Console.Write("Enter your gender (Write F for female or M for male > ");
            string femaleGender = Console.ReadLine();
            Boolean gender = string.Equals(femaleGender, "F", StringComparison.OrdinalIgnoreCase);
            if (gender == false)
            {
                Console.WriteLine("MAN!! go away!");
            }
            else
                Console.WriteLine("You are a strong women! :)");
            Console.ReadKey();
        }

    }
}

