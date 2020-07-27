using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelBaraTIao
{
    [Table("Fabricantes", Schema = "BaraTIao")]
    class Fabricante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome do fabricante.")]
        [MaxLength(100)]
        [DisplayName("Fabricante:")]
        public int Descricao { get; set; }

        [MaxLength(100)]
        [Display(Name = "Site:"), DataType(DataType.Url)]
        public string Website { get; set; }
    }
}
