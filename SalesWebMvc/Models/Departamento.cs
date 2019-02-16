using SalesWebMvc.Models.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class Departamento : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Nome do Departamento")]
        public string Nome { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }

        public int EmpresaId { get; set; }
    }
}
