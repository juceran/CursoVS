using SalesWebMvc.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Pessoa : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres")]
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        //relacionamento entre pessoas   
        //public int? PessoaClienteId { get; set; }
        public PessoaCliente PessoaCliente { get; set; }

        public ICollection<PessoaEmail> PessoaEmail { get; set; } = new List<PessoaEmail>();
        //public int? PessoaEmailId { get; set; }

        public ICollection<PessoaEndereco> PessoaEndereco { get; set; } = new List<PessoaEndereco>();
        //public int? PessoaEnderecoId { get; set; }

        //public int? PessoaFisicaId { get; set; }
        public  PessoaFisica PessoaFisica{ get; set; }

        //public int? PessoaFornecedorId { get; set; }
        public  PessoaFornecedor PessoaFornecedor { get; set; }

        //public int? PessoaJuridicaId { get; set; }
        public  PessoaJuridica PessoaJuridica { get; set; }
 
        public ICollection<PessoaTelefone> PessoaTelefone { get; set; } = new List<PessoaTelefone>();

        //public int? PessoaUsuarioId { get; set; }
        public PessoaUsuario PessoaUsuario { get; set; }
    }
}
