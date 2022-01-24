using System.Collections.Generic;
using XMLImporter.WinFormsMVP.Model;

namespace XMLImporter.WinFormsMVP.MockData
{
    public interface IProjectRepository
    {
        IList<ProjectItem> GetProjects(string domain);
    }

    public class ProjectRepository : IProjectRepository
    {
        public IList<ProjectItem> GetProjects(string domain)
        {
            var list = new List<ProjectItem>(3);

            if (domain == "Domain-1")
            {
                list.Add(new ProjectItem() { Id = 1, Name = "Project-11", DomainName = domain });
                list.Add(new ProjectItem() { Id = 2, Name = "Project-12", DomainName = domain });
                list.Add(new ProjectItem() { Id = 3, Name = "Project-13", DomainName = domain });
            }
            else if (domain == "Domain-2")
            {
                list.Add(new ProjectItem() { Id = 4, Name = "Project-21", DomainName = domain });
                list.Add(new ProjectItem() { Id = 5, Name = "Project-22", DomainName = domain });
                list.Add(new ProjectItem() { Id = 6, Name = "Project-23", DomainName = domain });
            }
            else if (domain == "Domain-3")
            {
                list.Add(new ProjectItem() { Id = 7, Name = "Project-31", DomainName = domain });
                list.Add(new ProjectItem() { Id = 8, Name = "Project-32", DomainName = domain });
                list.Add(new ProjectItem() { Id = 9, Name = "Project-33", DomainName = domain });
            }
            else
            {
                //not implemented
            }

            return list;
        }
    }
}
