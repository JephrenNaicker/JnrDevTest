using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question1;

namespace PersonBuilder.Test
{
    [TestClass]
    public class PersonBuilderTest
    {


        [ClassInitialize]
        public void SetUp()
        {
            _loggingService = new PersonBuilder();
            _userManager = new UserManager();
        }


        [TestMethod]
        public void Check_If_ID_isVaild()
        {
            string input = "25";
            var expected = 1;
            var x = '1';


            PersonBuilder s = new PersonBuilder();

        }
    }
}
