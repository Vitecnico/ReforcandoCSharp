using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    public class Funcionario
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario(string name,int idade, double salario)
        { 
            Name = name;
            Idade = idade;
            Salario = salario;
        
        }
    }
}
