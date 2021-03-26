using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    interface IPerson
    {


        int CheckSum(string val);

        bool IsSA(string val);

        DateTime getDOB(string val);

        string GetGender(string val);
    }
}
