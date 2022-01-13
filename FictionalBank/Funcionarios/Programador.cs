using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    internal class Programador : Funcionario
    {
        public Programador(string name, string cpf, int idade, double salario) : base(name, cpf, idade, salario)
        {
        }
    }
}
