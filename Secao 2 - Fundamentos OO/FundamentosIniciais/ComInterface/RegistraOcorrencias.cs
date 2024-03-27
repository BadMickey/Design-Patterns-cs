using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface
{
    public class RegistraOcorrencias
    {
        private readonly IRegistro _registro;

        public RegistraOcorrencias(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
