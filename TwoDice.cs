using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class TwoDice
    {
        public static void Main()
        {

            //1. Local variables and constants

            const int MAX = 7;
            const int MIN = 1;
            int ran;  //Varibale named ran

            //2. Creation of object class RANDOM named ranGenerator

            Random ranGenerator = new Random();

            //3. Creation of 2 dice and assignation of ran value

            ran = ranGenerator.Next(MIN, MAX); //Using method Next, que cambia al siguiente numero aleatorio
            Die die1 = new Die(ran);           //Creation of an object class Die with the value ran as parameter

            ran = ranGenerator.Next(MIN, MAX);
            Die die2 = new Die(ran);

            //Display values

            Console.WriteLine("The 2 die values are: " + die1.DieValue + " and " + die2.DieValue);

        }

    }
}
