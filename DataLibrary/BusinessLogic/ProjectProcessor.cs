using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class ProjectProcessor
    {
        public static int CreateProject(string projectName, string description)
        {
            ProjectModel data = new ProjectModel
            {
                ProjectName = projectName,
                Description = description
                
            };

            string sql = @"insert into dbo.Project (ProjectName, Description)
                        values (@ProjectName, @Description);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ProjectModel> LoadProjects()
        {
            string sql = @"select Id, ProjectName, Description
                            from dbo.Project;";
            return SqlDataAccess.LoadData<ProjectModel>(sql);
        }



    }
}
