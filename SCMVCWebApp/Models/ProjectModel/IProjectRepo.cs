using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ProjectModel
{
    public interface IProjectRepo
    {
        //List alll
        //Add
        //Edit
        //Delete
        //Complex work flows 

        List<Project> ListAllProjects();

        Project FindProject(int projectID);



    }
}
