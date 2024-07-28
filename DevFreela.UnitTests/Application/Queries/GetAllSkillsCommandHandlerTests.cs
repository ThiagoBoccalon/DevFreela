using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetAllSkills;
using DevFreela.Core.DTOs;
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
    public class GetAllSkillsCommandHandlerTests
    {
        public async void ThreeSkillsExist_executed_ReturnThreeSkillsViewModels()
        {
            // Arrange
            var skillsDTO = new List<SkillDTO>()
            {
                new SkillDTO(1, "Test's description 1"),
                new SkillDTO(2, "Test's description 2"),
                new SkillDTO(3, "Test's description 3")
            };

            var skillsRepositoryMock = new Mock<ISkillRepository>();
            skillsRepositoryMock.Setup(sr => sr.GetAllSkills().Result).Returns(skillsDTO);

            var getAllSkillsQuery = new GetAllSkillsQuery();
            var getAllSkillsQueryHandler = new GetAllSkillsQueryHandler(skillsRepositoryMock.Object);

            // Act
            var skillsViewModelList = await getAllSkillsQueryHandler.Handle(getAllSkillsQuery, new CancellationToken());

            // Assert
            Assert.NotNull(skillsViewModelList);
            Assert.NotEmpty(skillsViewModelList);
            Assert.Equal(skillsDTO.Count, skillsViewModelList.Count);

            skillsRepositoryMock.Verify(sr => sr.GetAllSkills().Result, Times.Once);
        }
        
    }
}
