using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Tests
{
    [TestClass()]
    public class PersonBuilderTests
    {

        PersonBuilder pBuilder = new PersonBuilder();

        public string input = "";

        [TestMethod()]
        public void CheckSumTest()
        {
            input = "85";

            int output = pBuilder.CheckSum(input);



            Assert.AreEqual(1, output);
        }

        [TestMethod()]
        public void getDOBTest()
        {
            input = "950705";

            DateTime output = pBuilder.getDOB(input);

            Assert.AreEqual("1995/07/05 00:00:00", output.ToString());

        }

        [TestMethod()]
        public void GetGenderTest()
        {
            input = "7508305802089";

            string output = pBuilder.GetGender(input);

            Assert.AreEqual("Male", output.ToString());

        }

        [TestMethod()]
        public void IsSATest()
        {
            input = "7508305802089";

            bool output = pBuilder.IsSA(input);

            Assert.IsTrue(output);

        }
    }
}