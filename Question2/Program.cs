using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        // Question 2:
        // Find every position in an input string where a letter is succeeded by itself
        // Please note that space is not a letter, each time a duplicated letter is found, write this letter plus it's position into the duplicate list
        
        /*
         * Example if data is "letter" position of t is 3 and value is tt
        */
            
        // NOTE: Please include comments in your code
        
        static void Main(string[] args)
        {
           const string data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commmodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
           //const string data = "Letter Loot";

            //const string data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";

            var duplicates = GetDuplicatedCharacters(data);


            Console.ReadLine();
        }

        private static List<StringPosition> GetDuplicatedCharacters(string data)
        {
      
            // Write your code here
            List<StringPosition> stringPositions = new List<StringPosition>();
            StringPostionBuilder stringPostionBuilder = new StringPostionBuilder();
            


            char[] ArrChar = stringPostionBuilder.ConvertToArrChar(data);


            for (int x = 0; x < ArrChar.Length - 1; x++)
            {
                var tempNext = ArrChar[x + 1];
                var tempHead = ArrChar[x];


                if (tempNext == tempHead)
                {


                    StringPosition Sp = new StringPosition() { DuplicatedPosition = x + 1, DuplicatedLetter = ArrChar[x] };
                    stringPositions.Add(Sp);
                }


            }


            stringPostionBuilder.DisplayList(stringPositions);

            return stringPositions;

        }
    }
}
