using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailboxAPI.Models.Repository;


namespace MailboxAPI.Models.DataManager
{
    public class FacturaManager : IDataRepository<Factura, long>
    {
        ApplicationContext ctx;
        public FacturaManager(ApplicationContext c)
        {
            ctx = c;
        }

        public long Add(Factura factura)
        {
            ctx.Facturas.Add(factura);
            long facturaID = ctx.SaveChanges();
            return facturaID;
        }

        public long Delete(long id)
        {
            int facturaID = 0;
            var factura = ctx.Facturas.FirstOrDefault(b => b.FacturaId == id);
            if (factura != null)
            {
                ctx.Facturas.Remove(factura);
                facturaID = ctx.SaveChanges();
            }
            return facturaID;
        }

        public Factura Get(long id)
        {
            var factura = ctx.Facturas.FirstOrDefault(b => b.FacturaId == id);
            return factura;
        }

        public IEnumerable<Factura> GetAll()
        {
            var facturas = ctx.Facturas.ToList();
            return facturas;
        }

        public long Update(long id, Factura item)
        {
            long facturaID = 0;
            var factura = ctx.Facturas.Find(id);
            if (factura != null)
            {
                factura.PO = item.PO;
                factura.NoteType = item.NoteType;

                facturaID = ctx.SaveChanges();
            }
            return facturaID;
        }
    }
}
