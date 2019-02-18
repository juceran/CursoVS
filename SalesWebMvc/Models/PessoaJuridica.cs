﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class PessoaJuridica : CamposComuns
    {
        [Column(TypeName = "varchar(16)")]
        public string CNPJ { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string IE { get; set; }

        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Razão social")]
        public string RazaoSocial { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string Fantasia { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Data de Abertura")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime DataAbertura { get; set; }

        //https://www.receitaws.com.br/v1/cnpj/70000401000127
        //campos que retornam da consulta ao site receita
        [Column(TypeName = "varchar(64)")]
        public string Situacao { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Data de Situação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataSituacao { get; set; }

        public string MotivoSituacao { get; set; }

        public string Complemento { get; set; }


        //Relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
