using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    public class Triangles
    {
       public void FindingCorrectTriagleTriplets()
        {
            int i = 0;
            string[] rowOfTriples = Console.ReadLine().Split(' ');
            
            
            int[] PythagorasTheory= new int[int.Parse(rowOfTriples[0])];

            for (i = 0; i < int.Parse(rowOfTriples[0]); i++)
            {
                string[] triplets = Console.ReadLine().Split(' ');
                int a = int.Parse(triplets[0]);
                int b = int.Parse(triplets[1]);
                int c = int.Parse(triplets[2]);
                if (a+b>c && b+c>a && a+c>b)
                {
                    PythagorasTheory[i] = 1;
                    
                }

                else
                {
                    PythagorasTheory[i] = 0;
                    
                }
                   
            }
            Console.WriteLine("{0}",string.Join(" " ,PythagorasTheory));
            Console.Read();
                
        }
    }
}
