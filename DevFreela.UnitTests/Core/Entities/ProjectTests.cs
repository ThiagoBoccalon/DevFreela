using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectIsCreated()
        {
            var project = GetOneProject();

            Assert.NotNull(project.Title);
            Assert.NotNull(project.Description);
            Assert.NotNull(project.IdClient);
            Assert.NotNull(project.IdFreelancer);
            Assert.NotNull(project.TotalCost);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);
        }
        public void TestIfProjectStatsWork()
        {
            var project = GetOneProject();            
            project.Start();

            Assert.NotNull(project);
            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
        }

        private Project GetOneProject()
        {
            return new Project("Name of test", "Description", 1, 2, 10000);
        }
    }
}
