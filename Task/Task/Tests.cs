using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task
{
    [TestFixture]
    public class Tests
    {
        private string path = "Resources/Users.json";

        [Test]
        public void Test1()
        { 
            List<UserModel> UsersList = DataReader.ReadJsonList<UserModel>(path);
            Console.WriteLine(UsersList[1]);
            //comment
        }
    }
}