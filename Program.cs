using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello \r\nWorld:)");
            Console.WriteLine();
            Console.WriteLine("LOVE IS IN THE AIR!");
            string first_name = "Chen";
            string last_name = "Ben-David";
            String full_name = String.Concat(first_name, " ", last_name);
            Console.WriteLine(full_name);

            Console.WriteLine("*****************************************************");

            string title = "*******ok, let's play!*******";


            Console.WriteLine(title.ToUpper());

            Console.Write("Insert your birth year > ");
            int birth_year = int.Parse(Console.ReadLine());
            int age = 2022 - birth_year;
            Console.WriteLine("your age is: "+age);
            Console.WriteLine("*****************************************************");

            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Your first name char is: " + name.First());
            Console.WriteLine("*****************************************************");

            Console.Write("Enter your Math grade > ");
            double Math_grade = double.Parse(Console.ReadLine());
            Console.Write("Enter your Hebrow grade > ");
            double Hebrow_grade = double.Parse(Console.ReadLine());
            Console.Write("Enter your English grade > ");
            double English_grade = double.Parse(Console.ReadLine());
            double Average = (Math_grade + Hebrow_grade + English_grade)/3;
            int rounded_average = (int)Average;
            Console.WriteLine("Your schoole average is: " + Average +", But you can round it to: " + rounded_average);
            Console.WriteLine("*****************************************************");

            string firstN = "chen";
            string lastN = "Ben-David";
            int Age_chen = 31;
            Age_chen.ToString();
            Console.WriteLine(Age_chen);
            string fullN = (firstN + lastN);
            Console.WriteLine(fullN.ToUpper() + (fullN.Count()));
            bool result = (fullN.Count()).Equals(Age_chen);
            Console.WriteLine(result);
            Console.WriteLine("*****************************************************");


            Console.Write("Enter your gender (Write F for female or M for male > ");
            string female_gender = Console.ReadLine();
            Boolean Gender = string.Equals(female_gender,"F", StringComparison.OrdinalIgnoreCase);
            if (Gender == false)
            {
                Console.WriteLine("MAN!! go away!");
            }
            else
                Console.WriteLine("You are a strong women! :)");
                   
                   
                   

            Console.ReadKey();  

        }

    
    }
}
