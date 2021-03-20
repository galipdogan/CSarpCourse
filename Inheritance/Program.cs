using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FisrtName = "Galip"},
                new Student{FisrtName = "Ali"}, 
                new Person{FisrtName = "Ahmet"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FisrtName);
                
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }

    }

    class Person2
    {
        
    }

    class Customer:Person
    {
        public string Cİty { get; set; }
    }

    class Student:Person
    {
        public string Departmant { get; set; }
    }
}
