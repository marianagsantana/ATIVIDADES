// See https://aka.ms/new-console-template for more information

namespace atividade
{
    
}
internal class ListaUm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Exercicios:");
        Console.WriteLine("1: Cálculo de média");
        Console.WriteLine("2: Cálculo de área");
        Console.WriteLine("3: Cálculo de volume");
        Console.WriteLine("4: Comparação de valores");
        Console.WriteLine("5: Cálculo de Bhaskara");
        Console.WriteLine("6: Cálculo de velocidade média");
        Console.WriteLine("7: Cálculo de imposto");
        Console.WriteLine("8: Teste de par ou ímpar");
        Console.WriteLine("9: Comparação de Strings");
        Console.WriteLine("10: Conversão de ponto em String");
        Console.WriteLine("11: Cálculo de imposto de renda");

        Console.WriteLine("Digite o número do exercício que deseja executar: ");
        int AtividadeUm = int.Parse(Console.ReadLine());
        
        switch (AtividadeUm)
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
                break;

            case 2:
                Console.WriteLine("Digite o lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());
                double area = lado1 * lado2;
                Console.WriteLine("A área é: " + area);
                break;

            case 3:
                Console.WriteLine("Digite o lado 1: ");
                double lado3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o lado 2: ");
                double lado4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o lado 3: ");
                double lado5 = double.Parse(Console.ReadLine());
                double volume = lado3 * lado4 * lado5;
                Console.WriteLine("O volume é: " + volume);
                break;

            case 4:
                Console.WriteLine("Digite o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());
                if (valor1 > valor2)
                {
                    Console.WriteLine("O primeiro valor é maior que o segundo valor");
                }
                else if (valor1 < valor2)
                {
                    Console.WriteLine("O segundo valor é maior que o primeiro valor");
                }
                else
                {
                    Console.WriteLine("Os valores são iguais");
                }
                break;

            case 5:
                Console.WriteLine("Digite o valor de A: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de B: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de C: ");
                double c = double.Parse(Console.ReadLine());
                double delta = (b * b) - (4 * a * c);
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("O valor de X1 é: " + x1);
                Console.WriteLine("O valor de X2 é: " + x2);
                break;

            case 6:
                Console.WriteLine("Digite a distância percorrida em km: ");
                double distancia = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tempo gasto em h: ");
                double tempo = double.Parse(Console.ReadLine());
                double velocidade = distancia / tempo;
                Console.WriteLine("A velocidade média é: " + velocidade);
                break;

            case 7:
                Console.WriteLine("Digite o valor do salário: ");
                double salario = double.Parse(Console.ReadLine());
                
                if{
                    salario <= 1903.98
                    Console.WriteLine("Isento");
                }
                else if{
                    salario >= 1903.99 && salario <= 2826.65
                    double imposto = salario * 0.075;
                    Console.WriteLine("O valor do imposto é: " + imposto);
                }
                else if{
                    salario >= 2826.66 && salario <= 3751.05
                    double imposto = salario * 0.15;
                    Console.WriteLine("O valor do imposto é: " + imposto);
                }
                else if{
                    salario >= 3751.06 && salario <= 4664.68
                    double imposto = salario * 0.225;
                    Console.WriteLine("O valor do imposto é: " + imposto);
                }
                else{
                    salario >= 4664.68
                    double imposto = salario * 0.275;
                    Console.WriteLine("O valor do imposto é: " + imposto);
                }

                break;

            case 8:
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
                else
                {
                    Console.WriteLine("O número é ímpar");
                }
                break;

            case 9:
                Console.WriteLine("Digite a primeira palavra: ");
                string palavra1 = Console.ReadLine();
                Console.WriteLine("Digite a segunda palavra: ");
                string palavra2 = Console.ReadLine();
                if (palavra1 == palavra2)
                {
                    Console.WriteLine("As palavras são iguais");
                }
                else
                {
                    Console.WriteLine("As palavras são diferentes");
                }
                break;

            case 10:
                Console.WriteLine("Digite o valor do ponto: ");
                double ponto = double.Parse(Console.ReadLine());
                string pontoString = ((int)ponto).ToString();
                Console.WriteLine("O valor do ponto em String é: " + pontoString);
                break;

            case 11:
                Console.WriteLine("Digite o salário: ");
                double salario1 = double.Parse(Console.ReadLine());
                if (salario1 <= 1903.98)
                {
                    Console.WriteLine("Isento");
                }
                else if (salario1 >= 1903.99 && salario1 <= 2826.65)
                {
                    double imposto1 = salario1 * 0.075;
                    Console.WriteLine("O valor do imposto é: " + imposto1);
                }
                else if (salario1 >= 2826.66 && salario1 <= 3751.05)
                {
                    double imposto2 = salario1 * 0.15;
                    Console.WriteLine("O valor do imposto é: " + imposto2);
                }
                else if (salario1 >= 3751.06 && salario1 <= 4664.68)
                {
                    double imposto3 = salario1 * 0.225;
                    Console.WriteLine("O valor do imposto é: " + imposto3);
                }
                else
                {
                    double imposto4 = salario1 * 0.275;
                    Console.WriteLine("O valor do imposto é: " + imposto4);
                }
                break;        

            default:
                Console.WriteLine("Exercício não encontrado");
                break;
        }

}
}

