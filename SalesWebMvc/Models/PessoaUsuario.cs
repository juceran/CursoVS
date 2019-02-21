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
    public class PessoaUsuario : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Usuário")]
        public String Usuario { get; set; }

        //referencias de relacionamentos 
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public PessoaUsuarioSenha PessoaUsuarioSenha { get; set; }
    }
}
