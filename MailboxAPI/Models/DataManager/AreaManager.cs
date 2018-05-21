using MailboxAPI.Models.Entities;
using MailboxAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailboxAPI.Models.DataManager
{
    public class AreaManager : IDataRepository<AreaManager, long>
    {
        ApplicationContext ctx;
        public AreaManager(ApplicationContext c)
        {
            ctx = c;
        }

        public long Add(AreaManager b)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public AreaManager Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AreaManager> GetAll()
        {
            throw new NotImplementedException();
        }

        public long Update(long id, AreaManager b)
        {
            throw new NotImplementedException();
        }
    }
}
