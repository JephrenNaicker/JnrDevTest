using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question1
{
    class Program
    {
        // Question 1: 
        // The purpose of this question is to write a method to extract information 
        // about a person based on their ID number.
        /*
            Write an algorithm to extract:
                1. The persons date of birth
                2. Gender
                3. Citizenship
                4. If the ID Number is valid
             A South African ID Number is broken down as follows:
                - The first 6 digits are the persons date of birth in the format YYMMDD
                - The next 4 digits indicate gender:
                    >> 0000 - 4999 = FEMALE
                    >> 5000 - 9999 = MALE
                - The 11th digit indicates citizenship of the person - 
                    >> 0 indicates a South African citizen
                    >> 1  indicates a foreign citizen
                - The last to digits are a checksum based on Luhn algorithm, this is used to validate the ID number
        */

        // NOTE: Please include comments in your code

        static void Main(string[] args)
        {
            var idNumberList = new List<string>
            {
                "7508305802089",
                "7512305802089",
                "9507050010085"
            };
        

            Program pb = new Program();

            foreach (var id in idNumberList)
            {
                var person = pb.ValidateAndExtractInformation(id);
                Console.WriteLine($"Details for person with ID Number: {id}");
                Console.WriteLine($"Person Date Of Birth: {person.DateOfBirth.ToString()}");
                Console.WriteLine($"Person Gender: {person.Gender}");
                Console.WriteLine($"Is person a South African Citizen: {person.isSouthAfricanCitizen.ToString()}");
                Console.WriteLine($"Is ID Number Valid: {person.isValidIDNumber}");
                Console.WriteLine($"**************************************************");
            }

            Console.ReadLine();
        }

        public Person ValidateAndExtractInformation(string idNumber)
        { 
            PersonBuilder personBuilder = new PersonBuilder();
            bool isVal = false;
            
            if (personBuilder.CheckSum(idNumber.Substring(11, 2)) == 1)
            {
                isVal = true;
            }


            Person p = new Person();
            p.DateOfBirth = personBuilder.getDOB(idNumber);
            p.Gender = personBuilder.GetGender(idNumber);
            p.isSouthAfricanCitizen = personBuilder.IsSA(idNumber);
            p.isValidIDNumber = isVal;

            return p;


        }

    }
}
