using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelBaraTIao
{
    [Table("Categorias", Schema = "BaraTIao")]
    class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome da categoria.")]
        [MaxLength(100)]
        [DisplayName("Categoria:")]
        public int Descricao { get; set; }

        public int? IdCategoriaPai { get; set; }

        public virtual Categoria CategoriaPai { get; set; }
    }
}
