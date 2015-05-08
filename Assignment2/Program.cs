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

            //string[,] person = new string[,] 
            //{
            //    {"Janie","Clarke","8/19/1991","Dallas","TX","75205"},
            //    {"Hagan","McPhail","8/14/1991","Lonestar","MS","30000"},
            //    {"Bill","Wettingfeld","1/1/1989","Plano","TX","75023"},
            //    {"Steve","Sanders","2/6/1975","Coppell","TX","75019"},
            //    {"Steve","Wallace","9/6/1975","Fort Worth","TX","76101"}
            //};

            List<Person> people = GetPeople();

            Console.Write("Search First Names For: ");

            string userSearchTerm = Convert.ToString(Console.ReadLine());

            bool foundMatch = false;

            foreach (Person person in people)
            {
                string input = userSearchTerm.ToUpper();

                string firstName = person.FirstName.ToUpper();
                string lastName = person.LastName.ToUpper();

                if (firstName.Contains(input) || lastName.Contains(input))
                {
                    Console.Write(String.Format("{0} {2} {3} {1} {4}",
                        person.FirstName,
                        person.LastName,
                        person.City,
                        person.State,
                        person.Zip));

                    foundMatch = true;
                }

                if (foundMatch)
                {
                    Console.WriteLine();
                }

                foundMatch = false;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        private static List<Person> GetPeople()
        {
            var people = new List<Person>();

            Person janie = new Person()
            {
                FirstName = "Janie",
                LastName = "Clarke",
                DateOfBirth = DateTime.Now,
                City = "Dallas",
                State = "TX",
                Zip = "75305"
            };

            people.Add(janie);

            return people;
        }

    }
}
