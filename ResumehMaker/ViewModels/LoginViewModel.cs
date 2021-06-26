﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Campo obrigatório!")]
        [StringLength(50, ErrorMessage ="Use menos caracteres..")]
        [EmailAddress(ErrorMessage ="Email inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(50, ErrorMessage = "Use menos caracteres..")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}
