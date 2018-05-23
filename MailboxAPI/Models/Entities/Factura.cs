using MailboxAPI.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailboxAPI.Models.Entities
{
    [Table("tblFacturas")]
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string CNPJ { get; set; }
        public string PO { get; set; }
        public string NoNote { get; set; }
        public string TotalValue { get; set; }
        public string EmissionDate { get; set; }
        public string NoteType { get; set; }
        
        [ForeignKey("Area")]
        public long Area_id { get; set; }
        public virtual Area Area { get; set; }                

        public byte[] PdfPath { get; set; }
    }
}
