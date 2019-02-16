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
    public class PessoaUsuarioSenha : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        //Relacionamentos        
        public PessoaUsuario PessoaUsuario { get; set; }

        [ForeignKey("PessoaUsuario")]
        public int PessoaUsuarioId { get; set; }
    }
}

