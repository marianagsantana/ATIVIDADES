
namespace atividade
{
    
}
internal class ListaCinco 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Exercicios:");
        Console.WriteLine("1: Pessoa");
        Console.WriteLine("2: IMC");
        Console.WriteLine("3: Conta Corrente");
        Console.WriteLine("4: Deposito e Saque");
        Console.WriteLine("5: Area da Circunferencia");
        Console.WriteLine("6: Cifra de Cesar");

        Console.WriteLine("Digite o número do exercício que deseja executar: ");
        int AtividadeCinco = int.Parse(Console.ReadLine());

        switch (AtividadeCinco)
        {
            case 1:
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o peso: ");
                double peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a data de nascimento: ");
                string dataNascimento = Console.ReadLine();

                Pessoa1 pessoa1 = new Pessoa1(nome, peso, altura, dataNascimento);
                Console.WriteLine("O IMC é: " + pessoa1.IMC());
                break;

            case 2:
                Console.WriteLine("Digite o nome: ");
                string nome1 = Console.ReadLine();
                Console.WriteLine("Digite o peso: ");
                double peso1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura: ");
                double altura1 = double.Parse(Console.ReadLine());
                
                Pessoa2 pessoa = new Pessoa2(nome1, peso1, altura1);
                Console.WriteLine("O IMC é: " + pessoa.IMC());

                if (pessoa.IMC() < 18.5)
                {
                    Console.WriteLine("Abaixo do Peso");
                }
                else if (pessoa.IMC() >= 18.6 && pessoa.IMC() <= 24.9)
                {
                    Console.WriteLine("Peso Ideal");
                }
                else if (pessoa.IMC() >= 25.0 && pessoa.IMC() <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                }
                else if (pessoa.IMC() >= 30.0 && pessoa.IMC() <= 34.9)
                {
                    Console.WriteLine("Obesidade Grau I");
                }
                else if (pessoa.IMC() >= 35.0 && pessoa.IMC() <= 39.9)
                {
                    Console.WriteLine("Obesidade Grau II");
                }
                else if (pessoa.IMC() > 40)
                {
                    Console.WriteLine("Obesidade Grau III (mórbida)");
                }

                break;

            case 3:
                Console.WriteLine("Digite o número da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número da agência: ");
                int numeroAgencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do titular: ");
                string nomeTitular = Console.ReadLine();

                ContaCorrente contaCorrente = new ContaCorrente(numeroConta, numeroAgencia, saldo, nomeTitular);
                Console.WriteLine("Saldo: " + contaCorrente.SaldoTotal());
                break;

            case 4:
                Console.WriteLine("Digite o número da conta: ");
                int numeroConta1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número da agência: ");
                int numeroAgencia1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o saldo: ");
                double saldo1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do titular: ");
                string nomeTitular1 = Console.ReadLine();

                ContaCorrente contaCorrente1 = new ContaCorrente(numeroConta1, numeroAgencia1, saldo1, nomeTitular1);
                Console.WriteLine("Saldo: " + contaCorrente1.SaldoTotal());

                Console.WriteLine("Digite o valor do depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                contaCorrente1.Deposito(valorDeposito);
                Console.WriteLine("Saldo: " + contaCorrente1.SaldoTotal());

                Console.WriteLine("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                contaCorrente1.Saque(valorSaque);
                Console.WriteLine("Saldo: " + contaCorrente1.SaldoTotal());
                break;

            case 5:
                Console.WriteLine("Digite o valor do raio: ");
                double raio = double.Parse(Console.ReadLine());
                Circunferencia circunferencia = new Circunferencia(raio);
                Console.WriteLine("A área da circunferência é: " + circunferencia.Area());
                break;
            
            case 6:
                Console.WriteLine("Digite a palavra: ");
                string palavra = Console.ReadLine();
                Console.WriteLine("Digite o número de casas: ");
                int numeroCasas = int.Parse(Console.ReadLine());
                CifraCesar cifraCesar = new CifraCesar(palavra, numeroCasas);
                Console.WriteLine("A palavra cifrada é: " + cifraCesar.Cifrar());
                Console.WriteLine("A palavra decifrada é: " + cifraCesar.Decifrar());
                break;
                
            default:
        }
    }
}




//1) Crie uma classe que represente uma Pessoa, devendo ter as propriedades Nome,
//Peso, Altura e Data de Nascimento e o método IMC, que retornará o valor do IMC.

// 2) Crie um programa que receba a pessoa criada e verifique qual o IMC.

//IMC	Classificação 
///Abaixo de 18,5	Abaixo do Peso
//Entre 18,6 e 24,9	Peso Ideal
//Entre 25,0 e 29,9	Levemente acima do peso
//Entre 30,0 e 34,9	Obesidade Grau I
//Entre 35,0 e 39,9	Obesidade Grau II
//Acima de 40	Obesidade Grau III (mórbida)

//3) Crie uma classe que represente uma Conta Corrente, devendo ter as propriedades Número da Conta
//, Agência, Saldo, Nome do Titular e os métodos Depósito, Saque e Saldo Total. //
//4) Crie um programa que receba a conta corrente e deposite e saque valores, ao final imprimindo o saldo existente.
// 5) Crie uma classe que calcule a área de uma circunferência, recebendo com valor inicial o raio 
//6) Crie uma classe para Cifra de César, devendo ter um método criptografia e receba como valor inicial uma mensagem e o valor constante. Cifra de César é uma das criptografias mais antigas conhecidas, onde a chave está no valor constante, para cada letra do alfabeto atribuí-se um número (exemplo: A=1;B=2;C=3,etc), então para cada letra da mensagem, soma-se o valor correspondente a esta letra ao valor constante, gerando uma nova letra para formar a nova mensagem, ou seja, a mensagem "Ataque a roma" com um valor constante de 3 seria "dwdtxh d urpd". Dica, utilize arrays para isso.