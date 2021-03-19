using System;
using System.Threading.Channels;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Galip";
            customer1.LastName = "Doğan";
            customer1.City = "İzmir";

            //Farklı Kullanımıda şu şekilde

            Customer customer2 = new Customer {Id = 2,FirstName = "Ali",LastName = "Veli",City = "Ankara"};

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
