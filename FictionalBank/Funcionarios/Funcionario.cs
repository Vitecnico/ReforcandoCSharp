using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; protected set; }
        //o salario será protected para que seja modificado apenas pelas classes funcionario e seus filhos(como a classe diretor).
        public static int ContadorDeFuncionarios { get; private set; }

        public Funcionario(string name, string cpf, int idade, double salario)
        { 
            Name = name;
            CPF = cpf;
            Idade = idade;
            Salario = salario;
            ContadorDeFuncionarios++;
            Console.WriteLine("Funcionario de numero: " + ContadorDeFuncionarios);
        }

        public abstract double GetBonificacao();// A partir de 13/01/22 a bonificação de de cada cargo é diferente 
        
        public void GetInformacaoFuncionarios()
        {
            Console.WriteLine("");
            Console.WriteLine(Name);
            Console.WriteLine(CPF);
            Console.WriteLine("Idade: "+Idade);
            Console.WriteLine("Salario: "+Salario);
            Console.WriteLine("bonificação: " +GetBonificacao());//a bonificação 
            
            Console.WriteLine("");

        }
    }
}
