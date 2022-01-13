using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string name, string cpf, int idade, double salario) : base(name, cpf, idade, salario)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
