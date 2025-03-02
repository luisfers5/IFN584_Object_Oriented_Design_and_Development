using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Die
    {
        // Design a Die class that can hold an integer data field for a value (from 1 to 6). Include an auto
        //implemented property that holds the value of the die and a constructor that requires a value for the die

        //1. Fields -> Private variables that storage data. Privadas es _camelCase, locales es camelCase

        private int _dieValue;

        //2. Properties -> Encapsulated methods to acces fields. , if auto-implemented property =  public. PascalCase

        //Static means -> Belongs to the class, not the boject. Podemo usar el miembro de la clase sin crear un nuevo objeto

        public int DieValue  //{get; set;} forma sencilla
        {
            //
            get { return _dieValue; }
            // set { _dieValue = value; }    ---> Forma sencilla
            set
            {
                if(value < 1 || value > 6)
                {
                    Console.WriteLine("Invalid die value. Setting to 1 as default");
                    _dieValue = 1;
                }
                else
                {
                    _dieValue = value; 
                }
            }

        }

        //3. Constructors -> Special methods that initialize objects. Must have the same name as of the class and CAPITAL LETTER.
        //Can overload if multiple contructors with several parameters

        public Die(int v)
        {
            DieValue = v;
        }

        //4. Methods. Have parameters and return values or be VOID. PascalCase




    }
}
