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
            Funcionario bruno = new Funcionario("Bruno", 34, 2500);
            Console.WriteLine(123 - 321);
            Console.WriteLine(bruno.Name);
            Console.WriteLine(bruno.Idade);
            Console.ReadLine();
            
        }
    }
}
