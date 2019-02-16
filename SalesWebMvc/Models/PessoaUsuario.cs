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
        public String Usuario { get; set; }

        //referencias de relacionamentos 
        public Pessoa Pessoa { get; set; }
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }

        public PessoaUsuarioSenha PessoaUsuarioSenha { get; set; }
    }
}
