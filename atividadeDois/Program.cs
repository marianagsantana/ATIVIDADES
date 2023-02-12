namespace atividade
{   

}
internal class ListaDois
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Exercicios:");
        Console.WriteLine("1: Cálculo de média");
        Console.WriteLine("2: Cálculo de mês");
        Console.WriteLine("3: Jogo da forca");
        Console.WriteLine("4: Tabuada");
        Console.WriteLine("5: Imprimir String");
        Console.WriteLine("6: Soma de ímpares");
        Console.WriteLine("7: Média das Notas");
        Console.WriteLine("8: Fatorial");
        Console.WriteLine("9: IMC");

        Console.WriteLine("Digite o número do exercício que deseja executar: ");
        int AtividadeDois = int.Parse(Console.ReadLine());

        switch (AtividadeDois)
        {
            case 1:
                Console.WriteLine("Digite a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota: ");
                double nota3 = double.Parse(Console.ReadLine());
                double media = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("A média é: " + media);

                if (media > 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
                break;

            case 2:
                Console.WriteLine("Digite o número do mês:");
                int mes = int.Parse(Console.ReadLine());

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Março");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Maio");
                        break;
                    case 6:
                        Console.WriteLine("Junho");
                        break;
                    case 7:
                        Console.WriteLine("Julho");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Setembro");
                        break;
                    case 10:
                        Console.WriteLine("Outubro");
                        break;
                    case 11:
                        Console.WriteLine("Novembro");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro");
                        break;
                    default:
                        Console.WriteLine("Mês inválido");
                        break;
                }
                case 3: // jogo da forca
                Console.WriteLine("Digite a palavra oculta: ");
                string palavraOculta = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de tentativas: ");
                int tentativas = int.Parse(Console.ReadLine());
                string palavra = "";
                int erros = 0;
                int acertos = 0;

                for (int i = 0; i < tentativas; i++)        
                {
                    Console.WriteLine("Digite uma letra: ");
                    string letra = Console.ReadLine();

                    if (palavraOculta.Contains(letra))
                    {
                        palavra += letra;
                        acertos++;
                    }
                    else
                    {
                        erros++;
                    }

                    Console.WriteLine("Palavra: " + palavra);
                    Console.WriteLine("Erros: " + erros);
                    Console.WriteLine("Acertos: " + acertos);
                }

                if (erros == 6)
                {
                    Console.WriteLine("Você foi enforcado!");
                }
                else
                {
                    Console.WriteLine("Você acertou a palavra!");
                }
                break;

            case 4:
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + (i * j));
                    }
                }   
                break;

            case 5:
                Console.WriteLine("Digite uma palavra: ");
                string palavraString = Console.ReadLine();

                for (int i = 0; i < palavraString.Length; i++)
                {
                    Console.WriteLine(palavraString[i]);
                }
                break;

            case 6:
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                int soma = 0;

                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 != 0 && i % 7 == 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine("A soma é: " + soma);
                break;

            case 7:
                Console.WriteLine("Digite a nota: ");
                double nota = double.Parse(Console.ReadLine());
                double total = 0;
                int contador = 0;

                if (nota < 0)
                {
                    Console.WriteLine("Nota inválida");
                }

                else{
                    (nota > 0 && nota <= 10)
                    total += nota;
                    contador++;

                    Console.WriteLine("Digite a nota: ");
                    nota = double.Parse(Console.ReadLine());
                }

                double media1 = total / contador;
                Console.WriteLine("A média é: " + media1);
                break; 

                

            case 8:
                Console.WriteLine("Digite um número: ");
                int numero1 = int.Parse(Console.ReadLine());
                int fatorial = 1;

                for (int i = 1; i <= numero1; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine("O fatorial é: " + fatorial);
                break;

            case 9:
                Console.WriteLine("Digite a altura: ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso: ");
                double peso = double.Parse(Console.ReadLine());
                double imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc >= 18.6 && imc <= 24.9)
                {
                    Console.WriteLine("Peso normal");
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    Console.WriteLine("Obesidade grau 1");
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine("Obesidade grau 2");
                }
                else
                {
                    Console.WriteLine("Obesidade grau 3");
                }
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}