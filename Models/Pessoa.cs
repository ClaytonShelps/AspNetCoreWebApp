using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreWebApp.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }


        [MaxLength(100, ErrorMessage ="O Campo {0} deve ter no máximo {1} caracteres.")]
        [Required(ErrorMessage = "O campo {0} é de preencimento obrigatório.")]
        public string Nome { get; set; }


        [EmailAddress(ErrorMessage ="Informe um e-mail válido")]
        public string Email { get;}

    }

    public class PessoaFisica : Pessoa
    {
        [MaxLength(11, ErrorMessage = "O Campo {0} deve ter no máximo {1} caracteres.")]
        [RegularExpression(@"[0-9]{11}$",ErrorMessage ="O campo {0} deve ser preenchido com 11 digitos numéricos")]
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        [MaxLength(14, ErrorMessage = "O Campo {0} deve ter no máximo {1} caracteres.")]
        [RegularExpression(@"[0-9]{14}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 digitos numéricos")]
        public string CNPJ{ get; set; }

    }


}
