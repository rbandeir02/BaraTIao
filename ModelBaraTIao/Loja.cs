using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace ModelBaraTIao
{
    class Loja
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [DisplayName("Razão Social:")]
        [Required(ErrorMessage = "Por favor, insira a razão social.")]
        public string RazaoSocial { get; set; }

        public virtual Bairro EndereçoBairro { get; set; }

        [MaxLength(200)]
        [DisplayName("Endereço:")]
        [Required(ErrorMessage = "Por favor, insira o endereço.")]
        public string Endereco { get; set; }
    }
}
