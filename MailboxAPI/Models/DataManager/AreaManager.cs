using MailboxAPI.Models.Entities;
using MailboxAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailboxAPI.Models.DataManager
{
    public class AreaManager : IDataRepository<Area, long>
    {
        ApplicationContext ctx;

        public AreaManager(ApplicationContext c)
        {
            ctx = c;
        }        

        public long Add(Area area)
        {
            ctx.Areas.Add(area);
            ctx.SaveChanges();
            return area.id;
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Area Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Area> GetAll()
        {
            return ctx.Areas.ToList();
        }

        public long Update(long id, Area b)
        {
            throw new NotImplementedException();
        }        
    }
}
