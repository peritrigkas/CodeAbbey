using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    class SumOfDigits
    {
        int i = 0;
        public int[,,] DataArray = new int[3, 3, 3];

        string[] inputRows = Console.ReadLine().Split(' ');
        public int[,,] GetDataArray()
        {

            DataArray = new int[int.Parse(inputRows[0]), 1, 3];
            for (i = 0; i < int.Parse(inputRows[0]); i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                DataArray[i, 0, 0] = int.Parse(inputData[0]);
                DataArray[i, 0, 1] = int.Parse(inputData[1]);
                DataArray[i, 0, 2] = int.Parse(inputData[2]);
            }
            
            Console.ReadKey();
            return DataArray;

        }

        public void CalculateSumOfDigits()
        {
            GetDataArray();


            int[] arrayResult = new int[int.Parse(inputRows[0])];
            //string[] splitNum = new string[int.Parse(inputRows[0])];
            for (i = 0; i < int.Parse(inputRows[0]); i++)
            {
                int a = DataArray[i, 0, 0];
                int b = DataArray[i, 0, 1];
                int c = DataArray[i, 0, 2];

                arrayResult[i] = a * b + c;

            }
            int sum = 0; int j = 0;
            int[] sumDigits = new int[arrayResult.Length];
            for (j = 0; j < arrayResult.Length; j++)
            {
                for (int i = arrayResult[j]; i > 0; i = i / 10)
                {
                    sum = sum + i % 10;
                    sumDigits[j] = sum;
                }
                sum = 0;
            }
            Console.WriteLine("{0}", string.Join(" ", sumDigits));
            Console.ReadKey();




        }
    }


}
