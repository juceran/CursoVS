using SalesWebMvc.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class MenuLi : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "LI")]
        public string SubMenu { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "URL")]
        public string Url { get; set; }

        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        //Relacionamentos     
        public int MenuUlId { get; set; }
        public MenuUl MenuUl { get; set; }
    }
}
