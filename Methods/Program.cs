using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Farklı yerlerde çağırıp değişikliği sadece Add metdounda yaparız*/
            //Add();
            //Add();
            //Add();
            //Add();
            //var result= Add2(20, 30);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);


            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        /* static den sonra void yerine int yazmamızın nedeni void bir eylemi gerçekleşrirmek için
        ancak int yaparak değer döndürmesini istiyoruz.result değişkenimizde int tipinde olması gerekir. https://youtu.be/XZrgC78u_0U */
        static int Add2(int number1, int number2=30) //defaut parametre ile çalışmak eğer number 2 verilmezse 30 u kullan demektir.
                                                     //Birden fazla default verilebilir ancak tek default verilecekse her zaman en sonda olur.
        {
            var result = number1 + number2;
            return result;

        }

        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}

/*Değer tipler değerin kendisi ile ilgilenir. Referans ise sadece işaret edicidir*/
/*ref keyword ekleyerek number1 değişkenin referansını değiştirip eskiden 20 olan değeri artık add3 teki number1 gösteriri ve yeni değeri 30 olur
 buda değer tip değerinin referans tip olarak değiştirilmesini sağlar.*/