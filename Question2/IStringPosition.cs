using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    interface IStringPosition
    {
        char[] ConvertToArrChar(string val);

       void DisplayList(List<StringPosition> xList);
    } 
}
