using System.Collections.Generic;
using XMLImporter.WinFormsMVP.Model;

namespace XMLImporter.WinFormsMVP.MockData
{
    public interface IDomainRepository
    {
        IList<DomainItem> GetDomains();
    }

    public class DomainRepository : IDomainRepository
    {
        public IList<DomainItem> GetDomains()
        {
            var list = new List<DomainItem>(3);

            list.Add(new DomainItem() { Id = 1, Name = "Domain-1" });
            list.Add(new DomainItem() { Id = 2, Name = "Domain-2" });
            list.Add(new DomainItem() { Id = 3, Name = "Domain-3" });

            return list;
        }
    }
}
