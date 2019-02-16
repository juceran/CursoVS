using SalesWebMvc.Models.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class Departamento : CamposComuns
    {
        [Required]
        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Nome do Departamento")]
        public string Nome { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        
        [Display(Name = "Nome do Departamento")]
        public int EmpresaId { get; set; }
    }
}
