using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    class LinearFunction
    {
        
        int i,k = 0;
        string[] inputRows = Console.ReadLine().Split(' ');
        //string[] inputVariables;
        int[,] arrays= new int[40,40];
        public int[,] GetArrays()
        {
            for (i = 0; i < int.Parse(inputRows[0]); i++)
            {
                string[] inputVariables = Console.ReadLine().Split(' ');
                
                for (k = 0; k <inputVariables.GetLength(0); k++)
                {
                   
                    arrays[i,k] = int.Parse(inputVariables[k]);
                    //int b = int.Parse(inputVariables[1]);
                    //int c = int.Parse(inputVariables[2]);
                    //int d = int.Parse(inputVariables[3]);
                    
                }
            }
            int[,] array = new int[i,k];
            for (i = 0; i < array.GetLength(0) ; i++)

            {
                for (k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = arrays[i, k];

                }
                    
            }return array;


        }
              
        
        

        public int [,] FindParameters()
        {
            int a = 0; int b = 0;
            
            int c = 0; int d = 0;
           
            int[,] arrayInput = GetArrays();
            int[,] arrayResult = new int[arrayInput.GetLength(0),2];
            int[,] arrayResul = new int[arrayInput.GetLength(0), 2];
            for (i = 0; i < arrayInput.GetLength(0); i++)
            {
                a = arrayInput[i, 0];
                b = arrayInput[i, 1];
                c = arrayInput[i, 2];
                d = arrayInput[i, 3];


                int slope = (d - b) / (c - a);
                int constant = (b * c - d * a) / (c - a);
                arrayResult[i, 0] = slope;
                arrayResult[i, 1] = constant;
                


                

            }


            int lengthofArray = arrayResult.Length;

            for(i=0; i<arrayResult.GetLength(0);i++)
              Console.Write("(" + arrayResult[i,0] +" "+ arrayResult[i,1]+ ") ");
            //Console.WriteLine("{0}", string.Join(" ", arrayResult));
          //Console.WriteLine( String.Join((" "), arrayResult.Cast<int>() ));
            Console.ReadKey();
            return arrayResult;
        }
        
    }
}
