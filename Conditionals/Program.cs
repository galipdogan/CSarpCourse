using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            /*şart blokları if bloğunda else olduğundan sadece tek 1 blok çalışır. Else olmasaydı şart dışına çıkılınca çalışmayacaktır.*/
                //if (number==10)
                //{
                //    Console.WriteLine("Number is 10");

                //}else if (number==20)
                //{
                //    Console.WriteLine("Number is 20");
                //}
                //else
                //{
                //    Console.WriteLine("Number is no 10 or 20");
                //}

                /*switch case*/
                //switch (number)
                //{
                //    case 10:
                //        Console.WriteLine("Number is 10");
                //        break;
                //    case 20:
                //        Console.WriteLine("Number is 20");
                //        break;
                //    default:
                //        Console.WriteLine("Number is no 10 or 20");
                //        break;
                //}
                //    if (number>=0 && number<=100 )
                //    {
                //        Console.WriteLine("Number is between 0 - 100");
                //    }
                //    else if (number > 100 && number <= 200)
                //    {
                //        Console.WriteLine("Number is between 101 - 200");

                //    }else if (number > 200 || number <0)
                //    {
                //        Console.WriteLine("Number is less than 0 or greater than 200");
                //    }

                /*iç içe if kullanabiliriz Örnek güzel olmadı ama olsun*/

                //if (number<100)
                //{
                //    if (number>=90&&number<99)
                //    {
                //        Console.WriteLine("Number is between 90 - 99");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Number is between 0 - 89");
                //    }

                //    if (number >= 101 && number < 200)
                //    {
                //        Console.WriteLine("Number is between 101 - 200");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Number is between 101 - 200");
                //    }
                //}

                Console.ReadLine();
        }
    }
}
