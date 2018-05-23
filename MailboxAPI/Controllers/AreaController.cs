using MailboxAPI.Models.Entities;
using MailboxAPI.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailboxAPI.Controllers
{
    [Route("api/Area")]
    public class AreaController : Controller
    {
        private IDataRepository<Area, long> service;

        public AreaController(IDataRepository<Area, long> service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Area> Get()
        {
            return service.GetAll();
        }

        [HttpPost]
        public void Add([FromBody]Area area)
        {
            service.Add(area);
        }
    }
}
