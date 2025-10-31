using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidatosModel;

namespace CandidatosBusiness
{

    public interface IFuncionarioService
    {
        List <FuncionarioModel> ListarTodos();
    }
}
