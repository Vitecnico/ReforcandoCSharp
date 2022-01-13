using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    internal class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string name, string cpf, int idade, double salario) : base(name, cpf, idade, salario)
        {
        }
    }
}
