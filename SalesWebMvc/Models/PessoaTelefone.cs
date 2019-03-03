using SalesWebMvc.Models.Base;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class PessoaTelefone : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        [Display(Name = "Telefone")]
        public bool Fone { get; set; }

        [Column(TypeName = "varchar(16)")]
        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        //enums
        public TelefoneTipo Tipo { get; set; }

        //referencias de relacionamentos
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }       
    }
}
