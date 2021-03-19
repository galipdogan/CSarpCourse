using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();
            // Elimizdeki veriyi birden fazla veritanbınına kayıt ettik
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Galip";
            customer.LastName = "Doğan";
            customer.CostumerAdress = "İzmir";

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                Depertmant = "Computer Science"
            };

            personManager.Add(student);
            personManager.Add(customer);
            personManager.Add(new Worker());
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CostumerAdress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Depertmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Depertmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
