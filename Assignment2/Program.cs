using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //store collection of person objects in List/Array
            //person has FN, LN, DOB, City, State, Zip
            //allow user to be able to search person by name
            //console app will print off stats of each person found that matches search

            string[,] person = new string[,] 
            {
                {"Janie","Clarke","8/19/1991","Dallas","TX","75205"},
                {"Hagan","McPhail","8/14/1991","Lonestar","MS","30000"},
                {"Bill","Wettingfeld","1/1/1989","Plano","TX","75023"},
                {"Steve","Sanders","2/6/1975","Coppell","TX","75019"},
                {"Steve","Wallace","9/6/1975","Fort Worth","TX","76101"}
            };

            Console.Write("Search First Names For: ");

            string userSearch = Convert.ToString(Console.ReadLine());
            
            bool boolean = false;

            for (int i = 0; i < person.GetLength(0); i++)
            {
                for (int j = 0; j < person.GetLength(1); j++)
                {

                    string input = userSearch.ToUpper();

                    string firstName = Convert.ToString(person[i, 0]).ToUpper();
                    
                    if (firstName.Contains(input))
                    {

                        Console.Write(person[i, j] + " ");
                        boolean = true;
                    }   
                    
                }
                
                if (boolean == true)
                {
                    Console.WriteLine();
                }

                boolean = false;
                
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

    }
}
