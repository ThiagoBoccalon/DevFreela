using DevFreela.Application.Commands.CreateUser;
using DevFreela.Application.Queries.GetProjectById;
using DevFreela.Application.Queries.GetUser;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetUserQueryHandlerTests
    {
        [Fact]
        public async void OneUserExist_executed_ReturnUserViewModels()
        {
            //Arrange 

            var user = new User(
                "UserFullName",                
                "user@mail.com",
                DateTime.Now,
                "Abc@12345",
                "Client");

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(ur => ur.GetUsersAsync(user.Id).Result).Returns(user);

            var getUserQuery = new GetUserQuery(user.Id);
            var getUserQueryHandler = new GetUserQueryHandler(userRepositoryMock.Object);

            //Act
            var userViewModel = await getUserQueryHandler.Handle(getUserQuery, new CancellationToken());

            // Assert
            Assert.NotNull(userViewModel);
            Assert.Equal(userViewModel.FullName, user.FullName);
            Assert.Equal(userViewModel.Email, user.Email);


            userRepositoryMock.Verify(ur => ur.GetUsersAsync(user.Id).Result, Times.Once);
        }
    }
}
