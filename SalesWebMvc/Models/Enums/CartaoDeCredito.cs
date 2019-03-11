﻿using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models.Enums
{
    public enum CartaoDeCredito : int
    {
        [Display(Name = "Master Card")]
        MasterCard = 1,
        Visa =2,
        [Display(Name = "American Express")]
        AmericanExpress = 3,
        [Display(Name = "Hiper Card")]
        HiperCard = 4
    }
}
