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

            //int number1;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1);


            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Add4(1,2,3,4,5,6));
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

        static int Add3(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        /*Method overloading*/
        /*aynı veri tipini döndüren ancak fazla yada eksik parametre alan metodların isimlerini aynı verebiliriz.*/
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }


        /*Params keyword ile çalışmak birden aynı tipte overload olması durumunda kullanılır. büyük projelerde*/
        static int Add4(int number,params int[] numbers ) // Params metodun son parametresi olarak kullanılabilir. 
        {
            return numbers.Sum();
        }
     
    }
}

/*Değer tipler değerin kendisi ile ilgilenir. Referans ise sadece işaret edicidir*/
/*ref keyword ekleyerek number1 değişkenin referansını değiştirip eskiden 20 olan değeri artık add3 teki number1 gösteriri ve yeni değeri 30 olur
 buda değer tip değerinin referans tip olarak değiştirilmesini sağlar.*/

/*ref de number1 değişkeni set edilip 20 yazıldı ancak out keywordunda buna gerek yoktur. aradaki fark da budur.*/