using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [StringLength(1000, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        
        public int CurriculoId { get; set; }
        
        public Curriculo Curriculo { get; set; }

    }
}
