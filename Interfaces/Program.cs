using System;

namespace Interfaces
{
    class Program
    {
        //interface new lenemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();


            IPersonManager employeeManager = new EmployeeManager();


            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();

    }

    //class - inherits -------- interface - implements yazılır
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
