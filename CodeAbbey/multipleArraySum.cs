using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    public class MultipleArraySum
    {
        int i = 0;
        int[] total =new int[13];
        public MultipleArraySum()
        {
            
            
            for (i = 0; i < 13; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int Sum = int.Parse(tokens[0]) + int.Parse(tokens[1]);
                total[i] = Sum;
            }
            Console.WriteLine("{0}", string.Join(", ", total));





            Console.ReadLine();
          
        }

        
    }
        
        

    
}
