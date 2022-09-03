using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        public int  Quantidade { get; set; }

        public int Status { get; set; }
        
    }
}
