using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref örneği ref parametresi verildiğinde değişken içinde bir değer bulunması gerekiyor ve Addref içerisinde kendisinin değişmesini istiyorsanız. Addref içinde belirtebiliyoruz.

            int number1 = 10;
            int number2 = 100;
            var result1 = Addref(ref number1, number2);

            int number3;
            int number4 = 100;
            var result2 = Addout(out number3, number4);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            // Console.ReadLine();   
        }

        static int Addref(ref int number1, int number2)
        {
            //number1=30; //number1 burada yeni değeri 30 artık
            return number1 + number2;
        }

        //out örneği - out yazdığımız yerde number1 mutlaka boş bırakmamız gerekiyor ve Addout içinde number1 değer atamamız gerekiyor
        static int Addout(out int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }

    }
}