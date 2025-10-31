using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CandidatosModel
{
    public class FuncionarioModel
    {
        [Key]
        public int idFuncionario {  get; set; }
        public required string nome { get; set; }
        public required DateTime dtNascimento { get; set; }
        [Column(TypeName="NUMBER(18,2)")]
        public decimal vlSalario { get; set; }
    }
}
