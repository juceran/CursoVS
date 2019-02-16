using SalesWebMvc.Models.Base;
using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class PessoaEmail : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [Required(ErrorMessage = "e-mail é um campo obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido!")]
        [DataType(DataType.EmailAddress)]        
        public string Email { get; set; }

        //enums
        public EmailTipo Tipo { get; set; }

        //referencias de relacionamentos
        public Pessoa Pessoa { get; set; }
    }
}
