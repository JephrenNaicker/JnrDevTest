using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public class PersonBuilder : IPerson
    {

        bool isSA = false;

       
        public int CheckSum(string val)
        {
            char[] ValArr = val.ToCharArray();
            int[] CSumArr = new int[val.Length];


            //Convert char ->int Array
            for(int i = 0;i<val.Length;i++)
            {

                CSumArr[i] = Convert.ToInt32(ValArr[i]);
            }


            for(int i = 0; i < val.Length; i++)
            {

                int temp = CSumArr[i];
                temp = temp * 2;
                    if (temp> 9)
                {
                    temp = temp % 10 + 1;
                }

                CSumArr[i] = temp;

            }


            int tot = 0;
            for(int i = 0; i < val.Length; i++)
            {
                tot += CSumArr[i];
            }

            if (tot % 10 == 0)
            {
                return 1;
            }
            
                return 0;
            
        }

        public DateTime getDOB(string val)
        {
            string DOB = val.Substring(0, 6);

            var formattedDate = string.Format("{0:yyMMdd}", DOB);
           return DateTime.ParseExact(formattedDate, "yyMMdd", CultureInfo.InvariantCulture);
        }

        public string GetGender(string val)
        {
            string gender = val.Substring(6, 4);

            if (float.Parse(gender) <= 4999)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            return gender;
        }

        public bool IsSA(string val)
        {
            if (int.Parse(val.Substring(10, 1)) == 0)
            {
                isSA = true;
            }

            return  isSA;
        }




    }
}
