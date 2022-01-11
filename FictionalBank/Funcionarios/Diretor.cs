using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string name, string cpf, int idade, double salario) : base(name, cpf, idade, salario)
        {
            Console.WriteLine("Criando diretor(a) " + name);
        }

        public override double GetBonificacao() 
        {
            return Salario;
        }
    }
}
