using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel Usuario, string senha) 
        {
            bool usuarioAutenticado = Usuario.Autenticar(senha);
            if (usuarioAutenticado) 
            {
                Console.WriteLine("Bem vindo");
                return true;
            }
            Console.WriteLine("Tente novamente");
            return false;
        }
    }
}
