using SalesWebMvc.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class MenuUl : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "UL")]
        public string Menu { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "URL")]
        public string Url { get; set; }
    }
}
