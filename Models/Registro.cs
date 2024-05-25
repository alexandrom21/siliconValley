using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace siliconValley.Models
{
    [Table("t_registro")]
    public class Registro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string? Name {get;set;}

        public string? Job {get;set;}
    }
}