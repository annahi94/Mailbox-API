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

        public Area SaveOrUpdate(Area area)
        {
            if (area.id == 0)            
                ctx.Areas.Add(area);                       
            else
            {
                Area areaBd = ctx.Areas.Where(x => x.id == area.id).First();
                ctx.Entry(areaBd).CurrentValues.SetValues(area);
            }

            ctx.SaveChanges();
            return area;
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
            return ctx.Areas.OrderBy(x => x.name).ToList();
        }        

        public long Update(long id, Area b)
        {
            throw new NotImplementedException();
        }        
    }
}
