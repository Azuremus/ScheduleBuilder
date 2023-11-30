using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ScheduBuild
{
    internal class Personnel
    {

        public string Name { get; set; }

        public string Mon { get; set; }
        public string Tues { get; set; }
        public string Wed { get; set; }
        public string Thurs { get; set; }
        public string Fri { get; set; }
        public string Sat { get; set; }
        public string[] Subjects { get; set; }
        public string Subs { get; set; }




        public void TutorHours()
        {

            // creates index specifying string values
            var numTutors = new Dictionary<int, string>()
            {
                { 0, "1st" },
                { 1, "2nd" },
                { 2, "3rd" },
                { 3, "4th" },
                { 4, "5th" },
                { 5, "6th" },
                { 6, "7th" },
                { 7, "8th" },
                { 8, "9th" },
                { 9, "10th" },
                { 10, "11th" },
                { 11, "12th" }
            };

            bool correct = false;
            while (correct == false)
            {
                Console.WriteLine($"What is {Name}'s schedule for Mondays?");
                Mon = Console.ReadLine();
                Console.WriteLine($"What is {Name}'s schedule for Tuesdays?");
                Tues = Console.ReadLine();
                Console.WriteLine($"What is {Name}'s schedule for Wednesdays?");
                Wed = Console.ReadLine();
                Console.WriteLine($"What is {Name}'s schedule for Thursdays?");
                Thurs = Console.ReadLine();
                Console.WriteLine($"What is {Name}'s schedule for Fridays?");
                Fri = Console.ReadLine();
                Console.WriteLine($"What is {Name}'s schedule for Saturdays?");
                Sat = Console.ReadLine();
                Console.WriteLine($"\n\nYou have entered the following for {Name}'s schedule: \n{Hours()}");
                correct = YesNoCheck(correct);
            }
        }

        public void TutorSubs()
        {
            var numTutors = new Dictionary<int, string>()
            {
                { 0, "1st" },
                { 1, "2nd" },
                { 2, "3rd" },
                { 3, "4th" },
                { 4, "5th" },
                { 5, "6th" },
                { 6, "7th" },
                { 7, "8th" },
                { 8, "9th" },
                { 9, "10th" },
                { 10, "11th" },
                { 11, "12th" }
            };

            bool correct = false;
            while (correct == false)
            {
                int size;
                Console.WriteLine($"How many subjects does {Name} assist with?");
                while (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Only enter integer values");


                }
                Console.WriteLine($"What is {Name}'s 1st subject?");
                Console.WriteLine($"What is {Name}'s 1st subject?");
                Subjects[0] = Console.ReadLine();
                Subs = Subjects[0];
                for (int i = 1; i < Subjects.Length; i++)
                {
                    Console.WriteLine($"What is {Name}'s {numTutors[i]} subject?");
                    Subjects[i] = Console.ReadLine();
                    Subs += ", " + Subjects[i];
                }



                Console.WriteLine("\n\n");
                Console.WriteLine($"You have entered the following for {Name}'s subjects: \n{Subs}");
                correct = YesNoCheck(correct);

            }
        }


        public bool YesNoCheck(bool correct)
        {
            Console.WriteLine("Is this information correct? (y/n)");
            string input = Console.ReadLine();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("I'm sorry, please enter either 'y' or 'n'.");
                Console.WriteLine("Are these hours correct? (y/n)");
                input = Console.ReadLine();
                Console.WriteLine("\n\n");
            }
            if (input == "y")
            {
                correct = true;
            }
            return correct;
        }
        public string Hours()
        {
            string str = "|     Monday     |    Tuesday     |    Wednesday   |    Thursday    |     Friday     |    Saturday    |\n";


            str += $"|{Mon,16}|";
            str += $"{Tues,16}|";
            str += $"{Wed,16}|";
            str += $"{Thurs,16}|";
            str += $"{Fri,16}|";
            str += $"{Sat,16}|";

            return str;
        }



    }
}