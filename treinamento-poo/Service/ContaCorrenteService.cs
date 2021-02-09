using System;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    public class ContaCorrenteService
    {
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");

            var valor = double.Parse(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Numero = 87456,
                Agencia = 6751,                    
                Titular = "Gabriel",
                Saldo = 500
            };

            var saque = Sacar(valor, conta.Saldo);

            // mplemente a ação sacar aqui e exiba as informações para o usuário...
            Console.WriteLine("====================================");
            Console.WriteLine("Informações da conta do cliente: ");
            Console.WriteLine("Olá" + nome + ".");
            Console.WriteLine("Operação realizada com sucesso!");
            Console.WriteLine("Valor retirado: " + valor);
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);
            Console.WriteLine("Saldo: " + saque);
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");

            var valor = double.Parse(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Numero = 87456,
                Agencia = 6751,
                Titular = "Gabriel",                
                Saldo = 500
            };

            var deposito = Depositar(valor, conta.Saldo);

            Console.WriteLine("====================================");
            Console.WriteLine("Informações da conta do cliente: ");
            Console.WriteLine("Olá" + nome + ".");
            Console.WriteLine("Operação realizada com sucesso!");
            Console.WriteLine("Valor depositado: " + valor);
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Número: " + conta.Numero);
            Console.WriteLine("Saldo: " + deposito);

        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");

            var valor = double.Parse(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Numero = 87456,
                Agencia = 6751,
                Titular = "Gabriel",               
                Saldo = 500
            };

            var contaDestino = new ContaCorrente()
            {
                Numero = 7653,
                Agencia = 23564,
                Titular = "João",                
                Saldo = 750
            };

            var transferencia = Transferir(valor, conta.Saldo, contaDestino);

            Console.WriteLine("====================================");
            Console.WriteLine("Informações da conta do cliente: ");
            Console.WriteLine("Olá" + nome + ".");
            Console.WriteLine("Operação realizada com sucesso!");

        }

        // criar os métodos Sacar, Depositar e Transferir como private
        
        private double Sacar(double saldo, double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Não foi possível realizar o saque. Seu saldo é inferior ao valor do saque.");
                Console.WriteLine("Saldo = "+saldo);
                Console.WriteLine("Valor do saque = "+valor);
            }
            else
            {
                saldo -= valor;
                return saldo;
            }

            return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            return saldo;
        }

        private bool Transferir(double valor, double saldo, ContaCorrente contaDestino)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Não foi possível realizar a transferência. Seu saldo é inferior ao valor da transferência.");
                Console.WriteLine("Saldo = "+saldo);
                Console.WriteLine("Valor do saque = "+valor);
            }

            saldo -= valor;
            Depositar(valor, saldo);
            Console.WriteLine("Operação realizada com sucesso!");
            Console.WriteLine("Seu saldo é de: "+saldo);
            Console.WriteLine("Informações da conta destino");
            Console.WriteLine("Nome: "+contaDestino.Titular);
            Console.WriteLine("Agencia: "+contaDestino.Agencia);
            Console.WriteLine("Número: "+contaDestino.Numero);
            Console.WriteLine("Valor da transferência: "+valor);
            return true;
        }
        
    }
}
