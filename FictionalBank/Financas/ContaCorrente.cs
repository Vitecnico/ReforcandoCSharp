using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionalBank.Financas
{
    internal class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int Numero { get; }

        
        public int Agencia {get;}

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento " + nameof(agencia) + " deve ser maior que 0", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento " + nameof(numero) + " deve ser maior que 0", nameof(numero));
            }

            TotalDeContasCriadas++;
            Agencia = agencia;
            Numero = numero;

            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
                Console.WriteLine("");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por zero");
                throw;

            }
            
            

        }

        public bool Sacar(double valor)
        {

            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
