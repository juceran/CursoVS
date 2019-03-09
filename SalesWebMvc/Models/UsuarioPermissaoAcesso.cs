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
    public class UsuarioPermissaoAcesso : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        public bool Visualizar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Incluir { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Editar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Imprimir { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Baixar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Cancelar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool CancelarBaixa { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }
    
        public ICollection<PessoaUsuario> PessoaUsuario { get; set; } = new List<PessoaUsuario>();
        public ICollection<MenuUl> MenuUl { get; set; } = new List<MenuUl>();
        public ICollection<MenuLi> MenuLi { get; set; } = new List<MenuLi>();
    }
}
