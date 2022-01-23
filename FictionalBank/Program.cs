using FictionalBank.Financas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FictionalBank.Funcionarios;
//using FictionalBank.Sistema;

namespace FictionalBank
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Infos");
            CriacaoDeContas();
            Console.ReadLine();
            
        }
        static void CriacaoDeContas() 
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            
        }

    /*   static void CriacaoDeFuncionarios() 
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

        }*/

    }
}
