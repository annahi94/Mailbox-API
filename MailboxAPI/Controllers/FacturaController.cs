using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MailboxAPI.Models;
using MailboxAPI.Models.Repository;
using MailboxAPI.Models.DataManager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MailboxAPI.Controllers
{
    [Route("api/Factura")]
    public class FacturaController : Controller
    {
        private IDataRepository<Factura, long> _iRepo;
        public FacturaController(IDataRepository<Factura, long> repo)
        {
            _iRepo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Factura> Get()
        {
            return _iRepo.GetAll();

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Factura Get(int id)
        {
            return _iRepo.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Factura factura)
        {
            _iRepo.Add(factura);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Factura factura)
        {
            _iRepo.Update(factura.FacturaId, factura);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public long Delete(int id)
        {
            return _iRepo.Delete(id);
        }
    }
}
