using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student()
            {
              firstName = "Ivan",
              lastName = "Nosenko",
              studentAge = 18,
              studentNumber = "1714044"
            };
            string FullName = s.ToString();

            Address a = new Address()
            {
              country = "Bulgaria,",
              city = "Varna,",
              street = "Oborishte",
              address = "13A"
            };
            string FullAddress = a.ToString();

            s.Scores.Add(new Student.Score { Subject = "Mathematic for Computing", Mark = 3 });
            s.Scores.Add(new Student.Score { Subject = "Computing and Society", Mark = 4 });
            s.Scores.Add(new Student.Score { Subject = "Computer Architecture", Mark = 3 });
            s.Scores.Add(new Student.Score { Subject = "Principle of Programming", Mark = 3 });
            s.Scores.Add(new Student.Score { Subject = "Data Structures and Algorithms", Mark = 3 });
            s.Scores.Add(new Student.Score { Subject = "English", Mark = 5 });
            string Scores = s.ToExportString();

            List<int> Marks = new List<int>() { 3, 4, 3, 3, 3, 5 };
            double averageScore = Marks.Average();

            bool aboutstudent = true;
            while (aboutstudent)
            {
                Console.WriteLine(new string(' ', 10));
                Console.WriteLine("Press any key from 1 to 5 to select a specific action: ");
                Console.WriteLine(new string(' ', 10));
                Console.WriteLine("1 - Student's average score");
                Console.WriteLine("2 - Student's city");
                Console.WriteLine("3 - Student's full address");
                Console.WriteLine("4 - Student's full information");
                Console.WriteLine("5 - Exit");
                Console.WriteLine(new string(' ', 10));

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine(new string(' ', 10));
                    switch (choice)
                    {

                        case 1:
                            {
                                Console.WriteLine("Student {0} Average score: {1}", FullName, averageScore);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Student {0} living in {1}", FullName, a.city);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Student {0} Address: {1}", FullName, FullAddress);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(new string(' ', 10));
                                Console.WriteLine("Student {0}, {1} years old", FullName, s.studentAge);
                                Console.WriteLine(new string(' ', 10));
                                Console.WriteLine("Student number is {0}", s.studentNumber);
                                Console.WriteLine(new string(' ', 10));
                                Console.WriteLine("Full address: {0}", FullAddress);
                                Console.WriteLine(new string(' ', 10));
                                Console.WriteLine("{0}" , Scores); 
                                Console.WriteLine("Average score is: {0}", averageScore);
                                Console.WriteLine(new string(' ', 10));
                                break;
                            }
                        case 5:
                            {
                                aboutstudent = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid action, please enter the CORRECT action (from 1 to 5)");
                                break;
                            }
                    }
                }
                catch { }
                Console.WriteLine(new string(' ', 10));
                Console.WriteLine("To go back please press any Key..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

