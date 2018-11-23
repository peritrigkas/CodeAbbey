using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbey
{
    class FahrenheitToCelcious
    {
        public void Conversion()
        {
            int i = 0;
            //double[] Farhenheit = new double[i];
            string [] arrayOfData = Console.ReadLine().Split(' ');
            double[] celciousArray = new double[arrayOfData.Length];

            foreach(string Farheneit in arrayOfData)
            {
                double celcious = Math.Round((double.Parse(Farheneit) - 32) / 1.8);
                             
                celciousArray[i] = celcious;
                i++;
                
            }
            Console.WriteLine("{0}", string.Join(" ", celciousArray));
            Console.ReadKey();


        }
    }
}
