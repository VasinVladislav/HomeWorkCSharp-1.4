using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение « — вот какое число Вы ввели».
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number} — вот какое число Вы ввели");
        }
    }
}
