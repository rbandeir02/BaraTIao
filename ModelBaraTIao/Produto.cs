using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelBaraTIao
{
    class Produto
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira a descrição.")]
        [MaxLength(100)]
        [DisplayName("Descrição:")]
        public int Descricao { get; set; }

        [MaxLength(100)]
        [Display(Name = "Site do Fabricante:"), DataType(DataType.Url)]
        public string WebsiteFabricante { get; set; }

        [Required(ErrorMessage = "Por favor, insira o preço.")]
        [MaxLength(100)]
        [Display(Name = "Preço:"), DataType(DataType.Currency)]
        public double Preco { get; set; }

    }
}
