using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подбор_фильма
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа поможет выбрать фильм на вечер");
            String name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            Console.WriteLine("Какой жанр вы предпочитаете: комедия или драмма");
            String ganre = Console.ReadLine();

            Console.WriteLine("В таком случае можем Вам предложить:");
            if(ganre == "комедия")
            {
                Console.WriteLine("* Свадебный разгром");
                Console.WriteLine("* Третий лишний");
                Console.WriteLine("* 1+1");
                Console.WriteLine("* Не грози южному централу, попивая сок у себя в квартале");
               
            }
            else
            {
                Console.WriteLine("* 1+1");
                Console.WriteLine("* Леденец");
            }

            Console.ReadLine();

        }
    }
}
