using CandidatosData;
using CandidatosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidatosBusiness
{
    public class FuncionarioService(ApplicationDbContext context) : IFuncionarioService
    {
        private readonly ApplicationDbContext _context = context;

        public List<FuncionarioModel> ListarTodos() => [.. _context.Funcionarios];
    

    }
}
