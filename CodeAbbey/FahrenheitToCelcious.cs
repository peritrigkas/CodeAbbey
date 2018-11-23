using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    public class FahrenheitToCelcious
    {
        public int[] Conversion(int[] array)
        {
            int i = 0;
            //double[] Farhenheit = new double[i];
            //string [] arrayOfData = Console.ReadLine().Split(' ');
            int[] arrayOfData = new int[] { 3, 34, 565, 100, 212 };
            int[] celciousArray = new int[arrayOfData.Length];

            foreach(int Farheneit in arrayOfData)
            {
                int celcious = (int)Math.Round(((Farheneit) - 32) / 1.8);
                             
                celciousArray[i] = celcious;
                i++;
               
            }
            return celciousArray;
            //Console.WriteLine("{0}", string.Join(" ", celciousArray));
            //Console.ReadKey();
            


        }
    }
}
