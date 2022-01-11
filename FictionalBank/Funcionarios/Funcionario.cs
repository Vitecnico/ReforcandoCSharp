using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Funcionarios
{
    public class Funcionario
    {
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; protected set; }
        //o salario será protected para que seja modificado apenas pelas classes funcionario e seus filhos(como a classe diretor).

        public Funcionario(string name, string cpf, int idade, double salario)
        { 
            Name = name;
            CPF = cpf;
            Idade = idade;
            Salario = salario;
            
        }

        public virtual double GetBonificacao() 
        { 
           return Salario * 0.10;
            //aqui como exemplo o funcionario da FictionalBank recebe 10% do proprio salario como bonificação, a não ser que ele tenha um cargo de diretor
        }
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
