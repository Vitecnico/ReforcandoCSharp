using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FictionalBank.Funcionarios;
using FictionalBank.Sistema;

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
            SistemaInterno sistemaInterno = new SistemaInterno();
            Programador bruno = new Programador("Bruno","000.000.000-01", 34, 2500);
            Diretor laura = new Diretor("Laura", "000.000.001-01", 41, 4000);
            ParceiroComercial parceiro = new ParceiroComercial();
            bruno.GetInformacaoFuncionarios();
            laura.GetInformacaoFuncionarios();

            parceiro.Senha = "abc";
            laura.Senha = "1234";
            sistemaInterno.Logar(laura,"1234");
            sistemaInterno.Logar(parceiro, "abc");
            sistemaInterno.Logar(laura, "abc");
            sistemaInterno.Logar(parceiro, "abcd");

        }
      
    }
}
