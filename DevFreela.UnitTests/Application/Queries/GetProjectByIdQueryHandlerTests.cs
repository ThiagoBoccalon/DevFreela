using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetProjectById;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetProjectByIdQueryHandlerTests
    {
        public async void OneProjectExist_executed_ReturnProjectViewModels()
        {
            // Arrange
            var project = new Project("Name of Test 1", "Test's description 1", 1, 2, 10000);
            

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetDetailsByIdAsync(project.Id).Result).Returns(project);

            var getProjectByIdQuery = new GetProjectByIdQuery(project.Id);
            var getProjectByIdQueryHandler = new GetProjectByIdQueryHandler(projectRepositoryMock.Object);

            // Act
            var projectViewModel = await getProjectByIdQueryHandler.Handle(getProjectByIdQuery, new CancellationToken());

            // Assert
            Assert.NotNull(projectViewModel);
            Assert.Equal(projectViewModel.Id, project.Id);
            

            projectRepositoryMock.Verify(pr => pr.GetDetailsByIdAsync(project.Id).Result, Times.Once);
        }
    }
}
