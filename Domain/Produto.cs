using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Produto
    {
        private object p;

        public Produto(Guid id, string nome, int quantidade, int status)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Status = status;
        }

        //public Produto(Guid id, string nome, int quantidade, object p, int status)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Quantidade = quantidade;
        //    this.p = p;
        //    Status = status;
        //}

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        public int  Quantidade { get; set; }

        public int Status { get; set; }
        
    }
}
