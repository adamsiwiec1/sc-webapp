using SCMVCWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ProjectModel
{
    public class ProjectRepo : IProjectRepo
    {
        private ApplicationDbContext database;

        public ProjectRepo(ApplicationDbContext dbContext)
        {
            database = dbContext;

        }

        public Project FindProject(int projectID)
        {
            return database.Project.Find(projectID);
        }

        public List<Project> ListAllProjects()
        {
            return database.Project.ToList();
        }
    }
}
