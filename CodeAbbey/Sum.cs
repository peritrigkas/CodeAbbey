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
            new MultipleArraySum();

            string[] tokens = Console.ReadLine().Split(' ');
            string[] token = Console.ReadLine().Split(' ');
           
            int totalLine = 0;
            int i;

            for (i = 0; i < token.Length; i++)
            {
                totalLine = totalLine + int.Parse(token[i]);
            }

            
            Console.WriteLine(totalLine);
            Console.ReadLine();
        }
    }
}
