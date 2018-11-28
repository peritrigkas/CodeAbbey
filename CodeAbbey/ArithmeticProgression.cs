using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    public class ArithmeticProgression
    {
        int i,l,j,k = 0;
        //string[] inputRows = Console.ReadLine().Split(' ');

        // string[] inputNums = Console.ReadLine().Split(' ');

        //int[] resultArray= new int[100];
        public int[] progression(int[,,] array)
        {
            int arrayRows = array.GetLength(0);
            int arraysInRow = array.GetLength(1);
            int arraysIndividualLength = array.GetLength(2);
            int[] resultArray = new int[arrayRows*arraysInRow];

            for (i = 0; i < arrayRows; i++)
            {
                for(k=0; k < arraysInRow; k++)
                {
                    int A = array[i,k,0];
                    int B = array[i,k,1];
                    int N = array[i,k,2];
                    
                    for (l=0;l<N;l++)
            {
                resultArray[j] += A + l * B;
            }

                    j++;
                }
                                                     
                                
            }
            Console.WriteLine("{0}", string.Join(" ", resultArray));
            //Console.ReadKey();
            
            
            
           return resultArray;
        }
        
    }
        
}
