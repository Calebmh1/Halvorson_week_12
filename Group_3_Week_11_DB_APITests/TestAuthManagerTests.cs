using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group_3_Week_11_DB_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_3_Week_11_DB_API.Controllers;

namespace Group_3_Week_11_DB_API.Tests
{
    [TestClass()]
    public class TestAuthManagerTests
    {
        [TestMethod()]
        public void Check_Authentication_Failure()
        {
            TestAuthManager manager = new TestAuthManager("FakeKey12341234");

            user user = new user
            {
                username = "testUsername",
                password = "testPassword"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }

        [TestMethod()]
        public void Check_Successful_Response()
        {

            TestAuthManager manager = new TestAuthManager("AuthTest12345!@#$%");


            var user = new user
            {
                username = "test1",
                password = "pwd"
            };


            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public void format_Test()
        {

            TestAuthManager manager = new TestAuthManager("AuthTest12345!@#$%");

            Boolean result = false;

            var user = new user
            {
                username = "test1",
                password = "pwd"
            };


            var ret = manager.Authenticate(user.username, user.password);

            if(ret is string) 
            {
                result = true;
            }

            Assert.IsTrue(result);

        }

        [TestMethod()]
        public void bad_input_Check()
        {


            TestAuthManager manager = new TestAuthManager("AuthTest12345!@#$%");


            var user = new user
            {
                username = "test1",
            };


            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }


        [TestMethod()]
        public void Key_Character_Counter()
        {
            Boolean result = false;

            TestAuthManager manager = new TestAuthManager("AuthTest12345!@#$%");
            var user = new user
            {
                username = "test1",
                password = "pwd"
            };

      

            var ret = manager.Authenticate(user.username, user.password);

            if(ret.Length == 171)
            {
                result =true;
            }

            Assert.IsTrue(result);

        }

    }
}