using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailboxAPI.Models
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FacturaId { get; set; }
        public string CNPJ { get; set; }
        public string PO { get; set; }
        public string NoNote { get; set; }
        public string TotalValue { get; set; }
        public string EmissionDate { get; set; }
        public string NoteType { get; set; }
        public int Area { get; set; }
    }
}
