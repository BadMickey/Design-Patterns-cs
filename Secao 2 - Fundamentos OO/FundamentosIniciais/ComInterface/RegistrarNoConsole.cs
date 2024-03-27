using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface
{
    public class RegistrarNoConsole : IRegistro
    {
        public void RegistraInfo(string mensagem) 
        {
            Console.WriteLine($"info: {mensagem}");
        }
    }
}
