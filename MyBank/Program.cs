using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
          //Console.WriteLine("teste");

        Gerente gerenteCarlos = new Gerente (){
            Nome = "Carlos",
            CPF = "987.987.987-98",
            Salario = 2000,
            NumeroDeAgencias = 5
            };
			
        Vendedor vendedorDaniel = new Vendedor(){
            Nome =  "Daniel",
            CPF = "123.456.789-00",
            Salario = 1000,
            ClientesAtendidos = 7
        };

        vendedorDaniel.Bonificacao = vendedorDaniel.Salario;
        gerenteCarlos.Bonificacao = gerenteCarlos.Salario;

        Console.WriteLine("remuneracao tl gerente: " + gerenteCarlos.RemuneracaoTotal(gerenteCarlos.Salario, 2000));
        Console.WriteLine("remuneracao tl daniel: " + vendedorDaniel.RemuneracaoTotal(vendedorDaniel.Salario, 1000));
        }
    }
}







        /*Vendedor vendedorPedro = new Vendedor();
        vendedorPedro.Nome =  "Pedro";
        vendedorPedro.CPF = "321.654.987-00";
        vendedorPedro.Salario = 1000;*/
        /*
		ContaCorrente contaDoJuliano = new ContaCorrente("Juliano Rodrigues", 1234, 100, vendedorDaniel);
        contaDoJuliano.Conta = 234;
		ContaCorrente contaDoJoao = new ContaCorrente("João", 9876, 70, vendedorPedro);
		ContaCorrente contaDaDuda = new ContaCorrente("Maria Eduarda", 1234, 140, vendedorPedro);*/


        /*Console.WriteLine("Contas: ");
        Console.WriteLine("Conta 1: \nNome: " +contaDoJuliano.Titular+"\nAgência: "+contaDoJuliano.Agencia+"\nSaldo: "+contaDoJuliano.Saldo+"\n");
        Console.WriteLine("Conta 2: \nNome: " +contaDoJoao.Titular+"\nAgência: "+contaDoJoao.Agencia+"\nSaldo: "+contaDoJoao.Saldo+"\n");
        Console.WriteLine("Conta 3: \nNome: " +contaDaDuda.Titular+"\nAgência: "+contaDaDuda.Agencia+"\nSaldo: "+contaDaDuda.Saldo+"\n");*/
        /*
        Console.WriteLine("Funcionários: ");
        Console.WriteLine("Funcionario 1: \nNome: " +funcionarioDan.Nome+"\nCPF: "+funcionarioDan.CPF+"\nCargo: "+funcionarioDan.Cargo+"\nSalário: "+funcionarioDan.Salario+"\nComissão: "+funcionarioDan.Comissao);
        Console.WriteLine("Funcionario 2: \nNome: " +funcionarioPedro.Nome+"\nCPF: "+funcionarioPedro.CPF+"\nCargo: "+funcionarioPedro.Cargo+"\nSalário: "+funcionarioPedro.Salario+"\nComissão: "+funcionarioPedro.Comissao);*/
        /*
        Console.WriteLine("Operações: ");
        Console.WriteLine("\nSacando 50 reais da conta do Juliano: ");
        contaDoJuliano.Sacar(50);
        Console.WriteLine("Saldo do Juliano depois do saque: " +contaDoJuliano.Saldo);

        Console.WriteLine("\nDepositando 60 na conta da Duda: ");
        contaDaDuda.Depositar(60);
        Console.WriteLine("Saldo da Duda depois do depósito: " +contaDaDuda.Saldo);
    
        Console.WriteLine("\nTransferir 100 reais da Duda para o João: ");
        contaDaDuda.Transferir(100, contaDoJoao);
        Console.WriteLine("Saldo da Duda depois da transferência: " +contaDaDuda.Saldo);  
        Console.WriteLine("Saldo do João depois da transferência: " +contaDoJoao.Saldo);

        Console.WriteLine("\nNúmero de contas criadas: "+ContaCorrente.TotaldeContasCriadas);
        
        Console.WriteLine(vendedorDaniel.Bonificacao);
        Console.WriteLine("O salario do gerente Carlos é: " + gerenteCarlos.Salario);*/
	
