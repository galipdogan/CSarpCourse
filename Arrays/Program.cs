using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arrays aynı tipteki verileri tek bir dizi içinde tutulur.*/
            //Farklı kullanımları aşağıdadır
            string student1 = "Galip";
            string student2 = "Ahmet";
            string student3 = "Mehmet";

            string[] students = new string[3];
            students[0] = "Galip";
            students[1] = "Ahmet";
            students[2] = "Mehmet";

            string[] students2 = { "Galip", "Ahmet", "Mehmet" };
            students2[3] = "Ali";// bu şeklide ekleme yapamıyoruz. Dizi içinde eleman sayısı kaçtane ise o kadar ekleme yapabiliyonuz.

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
