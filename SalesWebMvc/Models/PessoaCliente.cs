using SalesWebMvc.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class PessoaCliente : CamposComuns
    {
        public bool Cliente { get; set; }

        //Relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }              
    }
}
