using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Serialization;

namespace ModelBaraTIao
{
    [Table("Bairros", Schema = "BaraTIao")]
    public class Bairro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Por favor, insira o nome do bairro.")]
        [MaxLength(100)]
        [DisplayName("Bairro")]
        public string Descricao { get; set; }

    }
}
