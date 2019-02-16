﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Login
    {
        [Required(ErrorMessage ="CNPJ da empresa é um campo obrigatório!")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Usuário é um campo obrigatório!")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Digite a senha de acesso ao sistema")]

        public string Senha { get; set; }

        internal bool ValidarLogin()
        {
            return true;
        }
    }
}
