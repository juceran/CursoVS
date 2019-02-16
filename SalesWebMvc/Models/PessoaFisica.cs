﻿using SalesWebMvc.Models.Base;
using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class PessoaFisica : CamposComuns
    {
        [Column("varchar(128)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Pai { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Mae { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string CPF { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string RG { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        //enums
        public Sexo Sexo { get; set; }

        //referencias de relacionamentos
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}