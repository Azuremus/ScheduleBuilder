using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScheduBuild
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
              

            // create dictionary for specifying indeces in the Tutors Peronnel array
            var numTutors = new Dictionary<int, string>() {
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
            // Build subject table from tutors
            Console.WriteLine("What quarter is this schedule for?");
            string quarter = Console.ReadLine();

            Console.WriteLine("How many tutors do you have?");

            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("integers only");
            }

            Personnel[] Tutors = new Personnel[x]; // sets array size to match the number of tutors entered
            string[] AllSubjects = new string[1] ;

            for (int i = 0; i < Tutors.Length; i++)
            {
                Tutors[i] = new Personnel(); // creates Personnel object in Tutors array
                Console.WriteLine($"Please enter the {numTutors[i]} tutor's name: ");
                Tutors[i].Name = Console.ReadLine(); // sets tutor's name to user input
                Tutors[i].TutorHours(); // sets tutor's hours
                Tutors[i].TutorSubs(); // sets tutor's subjects
            //    for(int j = 0; j<AllSubjects.Length; j++)
            //    {
            //        if (!AllSubjects.Contains(Tutors[i].Subjects[j])) 
            //        {
            //            AllSubjects.Append(AllSubjects[j]);
            //        }
            //    }
                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            }

            for (int j = 0; j < AllSubjects.Length; j++)
            {
                Console.WriteLine(AllSubjects[j]);
            }

            for (int i = 0; i < Tutors.Length; i++)
            {
                Console.WriteLine($"{Tutors[i].Name} assists with {Tutors[i].Subs}\n" +
                    $"Thier schedule is as follows:");
                Console.WriteLine(Tutors[i].Hours() + "\n\n\n");
            }
            

            string input = Changes();

            while (input == "y")
            {
                Console.WriteLine("Who's information would you like to change?\n Enter 'c' to cancel.");
                for (int i = 0; i < Tutors.Length; i++)
                {
                    Console.WriteLine(Tutors[i].Name);
                }
                string change = Console.ReadLine();
                if (change == "c") { input = "n"; }
                for (int i = 0; i < Tutors.Length; i++)
                {
                    if (change == Tutors[i].Name)
                    {
                        Console.WriteLine($"Would you like to change {change}'s hours (h) or subjects (s)? (h / s) \n(enter c to cancel) ");
                        string answer = Console.ReadLine();
                        if (answer == "h")
                        {
                            Tutors[i].TutorHours();
                        }
                        if (answer == "s")
                            Tutors[i].TutorSubs();
                        if (answer == "c")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, please enter: \n 'h' for hours, \n's' for subjects, \n or 'c' to cancel");
                        }
                        for (int j = 0; j < Tutors.Length; j++)
                        {
                            Console.WriteLine($"{Tutors[j].Name} covers the following subjects:\n {Tutors[j].Subs}\n\n" +
                                $"{Tutors[j].Name}'s schedule is as follows:");
                            Console.WriteLine(Tutors[j].Hours() + "\n\n\n");
                        }
                        input = Changes();
                    }
                }

            }

/*
            // Write this schedule to a text file
            using (StreamWriter writer = new StreamWriter($"C:\\devl\\Projects\\ScheduBuild\\Schedules\\{quarter}.txt"))
            {
                for (int i = 0; i < Tutors.Length; i++)
                {
                    writer.WriteLine($"{Tutors[i].Name} assists with {Tutors[i].Subs}\n" +
                        $"Thier schedule is as follows:");
                    writer.WriteLine(Tutors[i].Hours());
                    writer.WriteLine("\n\n\n");
                }

            }
*/
            Console.WriteLine("Thank you for using ScheduBuild!\n Goodbye!");


        }

        static string Changes()
        {
            Console.WriteLine("Would you like to make any changes? (y/n)");
            string input = Console.ReadLine();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("I'm sorry, please enter either 'y' or 'n'.");
                Console.WriteLine("Would you like to make any changes? (y/n)");
                input = Console.ReadLine();
                Console.WriteLine("\n\n");
            }
            return input;
        }
        
        
    }
}
