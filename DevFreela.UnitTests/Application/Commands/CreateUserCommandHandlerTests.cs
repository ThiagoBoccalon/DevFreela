using Castle.Core.Internal;
using DevFreela.Application.Commands.CreateUser;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Core.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateUserCommandHandlerTests
    {
        [Fact]
        public async Task InputUserIsOk_Executed_ReturnUserId()
        {
            // Arrange
            var authService = new Mock<IAuthService>();
            var userRepository = new Mock<IUserRepository>();

            var createUserCommand = new CreateUserCommand
            {
                FullName = "UserFullName",
                Password = "Abc@12345",
                Email = "user@mail.com",
                BirthDate = DateTime.Now,
                Role = "Client"
            };

            var createUserCommandHandler = new CreateUserCommandHandler(userRepository.Object, authService.Object); 

            // Act
            var id = await createUserCommandHandler.Handle(createUserCommand, new CancellationToken());

            // Assert            
            authService.Verify(a => a.ComputeSha256Hash(It.Is<string>(s => s == createUserCommand.Password)), Times.Once);            

            Assert.True(id >= 0);
        }
    }
}
