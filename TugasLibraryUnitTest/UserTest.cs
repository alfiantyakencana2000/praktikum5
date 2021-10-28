using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;


namespace TugasLibraryUnitTest
{
    [TestFixture]
    class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void IsValidUserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }
       
    }
}
