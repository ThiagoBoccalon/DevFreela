using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Core.Entities
{
    public class UserTests
    {
        [Fact]
        public void TestUser()
        {
            var user = new User(
                "UserNameFull",
                "user@mail.com",
                DateTime.Today,
                "Abcc@123",
                "client"
                );

            Assert.NotNull(user);

            Assert.NotEmpty(user.FullName);
            Assert.NotEmpty(user.Email);
            Assert.Equal(user.BirthDate, DateTime.Today);
            Assert.NotEmpty(user.Password);
            Assert.Equal(user.Role, "client");
        }
    }
}
