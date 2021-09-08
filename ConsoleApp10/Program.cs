using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        public static List<int> GradeList = new List<int>();
        
        
        static void Main(string[] args)
        {
            
            string choice;
             
            DisplayMenu();
            choice = Console.ReadLine();
            
            while (choice != "9")
            {

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ViewAllGrades();
                        
                        break;

                    case "2":
                        Console.Clear();
                        AddAGrade();
                        break;

                    case "3":
                        Console.Clear();
                        RemoveAGrade();
                        break;

                    case "4":
                        Console.Clear();
                        EditGrade();
                        break;

                    case "5":
                        Console.Clear();
                        ShowBestGrade();
                        break;
                    case "6":
                        Console.Clear();
                        ShowWorstGrade();
                        break;
                    case "7":
                        Console.Clear();
                        ShowAverage();
                        break;
                       
                    case "8":
                        Console.Clear();
                        ExitApp();
                        break;

                    default:
                        {
                            Console.WriteLine("That is not a valid choice, please re-enter");
                            Console.Clear();
                            DisplayMenu();
                            break;
                        }//end default

                        
                }//end switch

               
                DisplayMenu();
                choice = Console.ReadLine();
            } //end while

        } //end main

        static void DisplayMenu()
        {
            Console.WriteLine(" Grade Book Manager Pro");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1] View All Grades");
            Console.WriteLine("[2] Add Grade to Book");
            Console.WriteLine("[3] Remove Grade from Book");
            Console.WriteLine("[4] Edit Grade from Book");
            Console.WriteLine("[5] View Highest Grade");
            Console.WriteLine("[6] View Lowest Grade");
            Console.WriteLine("[7] View Average Grade");
            Console.WriteLine("[8] Exit GradeBook");           
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Enter a Choice:");
        }

        static void ViewAllGrades()
        {
            
            Console.WriteLine("You are Viewing [ All Grades }");
            int m = 0;
            List<int> FilterList = GradeList.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nViewing All Grades: ", m);
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }

           
        }

        static void AddAGrade()
        {
            Console.WriteLine("You are Viewing [ Add a Grade }");
            int p;
            int grades, n;
                           
                            Console.Write("\n                                            Add Grades to the system ");
                            Console.Write("\n                                          -----------------------------\n");

                            Console.Write("                                            How many Grades to be added : ");
                            n = Convert.ToInt32(Console.ReadLine());

                            for (p = 0; p < n; p++)
                            {
                                Console.Write("                                            Student {0} : ", p);
                                grades = Convert.ToInt32(Console.ReadLine());
                                GradeList.Add(grades);
                            }

        }

        static void RemoveAGrade()
        {
            Console.WriteLine("You are Viewing [ Remove a Grade }");
            int u;
            int grades1, k;

            Console.Write("\n                                            Removes Grades From the system ");
            Console.Write("\n                                          -----------------------------\n");

            Console.Write("                                            How many Grades to be Removed : ");
            k = Convert.ToInt32(Console.ReadLine());

            for (u = 0; u < k; u++)
            {
                Console.Write("                                            Student {0} : ", k);
                grades1 = Convert.ToInt32(Console.ReadLine());
                GradeList.Remove(grades1);
            }
        }

        static void EditGrade()
        {
            Console.WriteLine("You are Viewing [ Edit A Grade }");
        }

        static void ShowBestGrade()
        {
            Console.WriteLine("You are Viewing [ View Highest Grade }");
            Console.WriteLine(GradeList.Max());
        }

        static void ShowWorstGrade()
        {
            Console.WriteLine("You are Viewing [ View Lowest Grade }");
            Console.WriteLine(GradeList.Min());
        }

        static void ShowAverage()
        {
            Console.WriteLine("You are Viewing [ Average Grade }");
            Console.WriteLine(GradeList.Average());
        }

        static void ExitApp()
        {
            Environment.Exit(0);
            
        }

       






    }// end class
}//end namespace