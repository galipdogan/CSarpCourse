using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Value types*/
            /*Tam sayı veri tipi  int değer tipindedir ve sınırı -2,147,483,648 - 2,147,483,647 arasındaır.32bit yer kaplar*/
            int number1 = 2147483647;

            /*long int de kapsar ancak long bellekte daha çok yer kaplar ve sınırı 
              -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807 arasındaır. 64 bitlik yer kaplar */
            long number2 = 2147483648;

            /*shrot tam sayı tutar. -32,768 to 32,767 arasındadır. 16 bitlik yer kaplar */
            short number3 = -32768;

            /*byte veri tipi  0-255 arasındaır.8bit yer kaplar*/
            byte number4 = 255;

            /*bool mantıksal veri tipidir true yada false olur 0 yada 1 olur */
            bool condition = true;

            /*char değer tipidir.genelde ascii kodlarını tutmak için kullanabiliriz. */
            char character = 'A';

            /*double ondalıklı sayıları tutamak için kullanıyoz. 64bitlik yer kaplar bellekte.virgülden sonra 14-15 değer tutar */
            double number5 = 10.4;

            /*decimal double göre daha büyük verileri tutar. virgülden sonra 28-29 değer tutar*/
            decimal number6 = 10;

            /*var değişken tutmak için kullanılır. */
            var number7 = 10;
            number7 = 'A';
            //number7 = "A";// string veremiyoruz çünkü en başta var ile int olarak tanımlama yaptık.
            
       

            Console.WriteLine("Number1 is {0}" ,number1);
            Console.WriteLine("Number2 is {0}" ,number2);
            Console.WriteLine("Number3 is {0}" ,number3);
            Console.WriteLine("Number4 is {0}" ,number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)character); // char değişkenini int cevirebiliriz. 
            Console.WriteLine((int)Days.Friday);//enumda kaçıncı sırada ise o sıra numarasını verir
            


            Console.ReadLine();
        }
        /*enum merkezi bir noktadan alarak string şeklinde yazmamızı sağlıyor. Karşılaştırma yapar.*/
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}
