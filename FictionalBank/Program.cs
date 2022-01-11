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
            Console.WriteLine(1234 - 4321);
            Funcionario bruno = new Funcionario("Bruno", 34, 2500);
            Funcionario laura = new Diretor("Laura", 41, 4000);
            Console.WriteLine(123 - 321);
            Console.WriteLine(bruno.Name);
            Console.WriteLine(laura.GetType());
            Console.WriteLine(laura.Idade);
            Console.ReadLine();
            
        }
    }
}
