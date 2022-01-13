using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FictionalBank.Funcionarios;

namespace FictionalBank
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Infos");
            CriacaoDeFuncionarios();
            Console.ReadLine();
            
        }

        static void CriacaoDeFuncionarios() 
        {
            Funcionario bruno = new Programador("Bruno","000.000.000-01", 34, 2500);
            Funcionario laura = new Diretor("Laura", "000.000.001-01", 41, 4000);
            bruno.GetInformacaoFuncionarios();
            laura.GetInformacaoFuncionarios();

        }
      
    }
}
