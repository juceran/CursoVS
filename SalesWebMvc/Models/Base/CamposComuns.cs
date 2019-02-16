﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Base
{
    public class CamposComuns
    {
        //campos comuns nas tabelas
        public int Id { get; set; }
       
        public bool Ativo { get; set; }

        [Required]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime? UltimaAtualizacao { get; set; }

        public bool? Deletado { get; set; }

        [Display(Name = "Data de Exclusão")]
        [DataType(DataType.DateTime)]
        public DateTime? DeletadoData { get; set; }

    }
}
