using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumehMaker.Models
{
    public class ExperienciaProfissional
    {
        public int ExperienciaProfissionalId { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [Range(1920, 2021, ErrorMessage = "Ano inválido!")]
        public int AnoInicio { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [Range(1920, 2021, ErrorMessage = "Ano inválido!")]
        public int AnoFim { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatório!")]
        [StringLength(500, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.MultilineText)]
        public string DescricaoAtividades { get; set; }
        
        public int CurriculoId { get; set; }
        
        public Curriculo Curriculo { get; set; }

    }
}
