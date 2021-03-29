using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class StringPostionBuilder : IStringPosition
    {

        public char[] ConvertToArrChar(string val)
        {
            char[] ValArr = val.ToCharArray();
            return ValArr;
        }

        public void DisplayList(List<StringPosition> xList)
        {
            if (xList.Count == 0)
            {
                Console.WriteLine("No Duplicated Letter");

            }
            else
            {

                foreach (var x in xList)
                    Console.WriteLine("DuplicatedLetter = {0},DuplicatedPosition={1}", x.DuplicatedLetter, x.DuplicatedPosition);
            }
        }

       
    }
}
