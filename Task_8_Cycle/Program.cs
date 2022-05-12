using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу");
            string phrase = Console.ReadLine();

            Console.WriteLine("Введите кол-во повторений");
            int numberRepetitionsPhrase = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberRepetitionsPhrase; i++)
            {
                Console.WriteLine(phrase);
            }
        }
    }
}
