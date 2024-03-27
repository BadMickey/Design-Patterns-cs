using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemInterface
{
    public class RegistraOcorrencias
    {
        public void RegistrarNoConsole(string mensagem)
        {
            Console.WriteLine($" {mensagem} : {DateTime.Now}");
        }

        public void RegistrarNoArquivo(string caminho)
        {
            //codigo
        }
    }
}
