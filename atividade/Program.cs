// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
        }
}
}