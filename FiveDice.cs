using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week1
{
    internal class FiveDice
    {

        public static void Main()
        {
            //Use a Die class, write an application named FiveDice that randomly "throws" five dice for the comptuer and 
            //and five dice for a second playe. Display the balues and then decide
            // who winds based on  the following hierarchy of Die Values


            Console.Clear();

            //1. Local variables and cosntants

            const int MAX = 7;
            const int MIN = 1;
            const int NUMBEROFDICE = 5;
            int ran;
            Die[] computerArray = new Die[NUMBEROFDICE]; //Matriz de objetos DICE 
            Die[] playerArray = new Die[NUMBEROFDICE];

            Random ranGenerator = new Random(); //Random number generator
            int compMatch;      // Para almacenar el conteo de valores coincidentes mas alto
            int playerMatch;    // Para almacenar el conteo de valores coincidentes mas alto del jugador

            int count;  // Variable de control para lo bucles

            //Methods

            //2. Inicializar los dados para la computadora y el jugador con valores aleatorios

            for (count = 0; count < NUMBEROFDICE; ++count)
            {
                ran = ranGenerator.Next(MIN, MAX); //Genera un random number
                computerArray[count] = new Die(ran); //Crea un dado, asignaod con este random number y lo agrega al ubcacion 0 de lel array

                ran = ranGenerator.Next(MIN, MAX); //Lo mismo poero ahora para el jugador
                playerArray[count] = new Die(ran);
            }

            //3. Mostrar los valores de los dados para la computadora y el jugador

            //Para la computadora
            Console.WriteLine("Compter's dice: ");
            for(count = 0; count < NUMBEROFDICE; ++count)
            {
                Console.WriteLine(computerArray[count].DieValue + " "); //Mediante loop imprime los valores los dados del array 
            }

            //Para el jugador
            Console.WriteLine("Player's dice: ");
            for (count = 0; count < NUMBEROFDICE; ++count)
            {
                Console.WriteLine(playerArray[count].DieValue + " "); //Mediante loop imprime los valores los dados del array 
            }


            //4 Evaluar quien tiene el mayor numero de dados con el mismo valor

            compMatch = HowManySame(computerArray, NUMBEROFDICE);  // Obtener el máximo número de dados idénticos para la computadora.
            playerMatch = HowManySame(playerArray, NUMBEROFDICE);  //Para el jugador


            //Anunciar resultados basados en las coincidencias.

            if (compMatch == 1)
                Console.WriteLine("Computer has nothing");  // Si no hay coincidencias.
            else
                Console.WriteLine("Computer has " + compMatch + " of a kind");  // Mostrar número de coincidencias.

            if (playerMatch == 1)
                Console.WriteLine("Player has nothing");  // Si no hay coincidencias.
            else
                Console.WriteLine("Player has " + playerMatch + " of a kind");  // Mostrar número de coincidencias.


            //Decidir el ganador

            if(compMatch > playerMatch)
            {
                Console.WriteLine("Computer Wins!!");
            }
            else if (compMatch > playerMatch)
            {
                Console.WriteLine("Player 1 wins!!");
            }
            else
            {
                Console.WriteLine("It is a tie!!");  //Empate
            }

            //Retiene que no sem uestre la ruta
            Console.ReadKey();
        }

        // Extra. Metodo HowManySme:
        static int HowManySame(Die[] die, int num)
        {
            int[] same = new int[num];
            int x, y;
            int highest;
            for (x = 0; x < num; ++x)
                same[x] = 1; // every die matches itself
            for (x = 0; x < num - 1; ++x)
            {
                for (y = x + 1; y < num; ++y)
                    if (die[x].DieValue == die[y].DieValue)
                    {
                        same[x]++;
                    }
            }
            highest = same[0];
            for (x = 1; x < num; ++x)
                if (same[x] > highest)
                    highest = same[x];
            return highest;
        }
    }
}
