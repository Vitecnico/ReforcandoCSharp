using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    internal class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string name, string cpf, int idade, double salario) : base(name, cpf, idade, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
