using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string name, int idade, double salario) : base(name, idade, salario)
        {
            Console.WriteLine("teste");
        }
    }
}
