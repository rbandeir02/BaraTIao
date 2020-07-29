using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace ModelBaraTIao
{
    [Table("Lojas", Schema = "BaraTIao")]
    public class Loja
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [DisplayName("Razão Social")]
        [Required(ErrorMessage = "Por favor, insira a razão social.")]
        public string RazaoSocial { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "Por favor, selecione o bairro.")]
        public int BairroId { get; set; }

        [ForeignKey("BairroId")]
        [DisplayName("Bairro")]
        [Required(ErrorMessage = "Por favor, selecione o bairro.")]
        public Bairro EnderecoBairro { get; set; }

        [MaxLength(200)]
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Por favor, insira o endereço.")]
        public string Endereco { get; set; }
    }
}
