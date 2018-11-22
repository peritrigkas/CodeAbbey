using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    class Sum
    {    
           
        static void Main(string[] args)
        {
            MultipleArraySum mas = new MultipleArraySum();
            mas.MultipleArrayTotal();
            arraySum();
        }

        static void arraySum()
        {
            //string[] tokens = Console.ReadLine().Split(' ');
            Console.WriteLine("Type an array of numbers :");
            string[] token = Console.ReadLine().Split(' ');

            int totalLine = 0;
            int i;

            for (i = 0; i < token.Length; i++)
            {
                totalLine = totalLine + int.Parse(token[i]);
            }


            Console.WriteLine(" The sume is  " + totalLine);
            Console.ReadLine();
        }
    }
}
