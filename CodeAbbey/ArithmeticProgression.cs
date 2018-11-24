using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    public class ArithmeticProgression
    {
        int i,n,l = 0;
        //string[] inputRows = Console.ReadLine().Split(' ');

        // string[] inputNums = Console.ReadLine().Split(' ');

        int[] resultArray= new int[2];
        public int[] progression(int[,,] array)
        {
            //int rows = int.Parse(inputRows[0]);
           

            for (i = 0; i <2; i++)
            {
                int A = array[i,0,0];
                int B = array[i,0,1];
                int N = array[i,0,2];


                for(l=0;l<N;l++)
            {
                resultArray[i] += A + l * B;
            }

            }
            return resultArray;
            
           

        }
        
    }
        
}
