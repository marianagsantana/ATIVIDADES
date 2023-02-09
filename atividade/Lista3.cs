
namespace atividade
{
    
}
internal class ListaTres
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Exercicios:");
        Console.WriteLine ("1: Tabuada");
        Console.WriteLine ("2: Ler arquivo");
        Console.WriteLine ("3: Operações básicas");
        Console.WriteLine ("4: Exponenciação");
        Console.WriteLine ("5: Aleatorizar nomes");
        Console.WriteLine ("6: Raio e área de uma circunferência");
        Console.WriteLine ("7: Verificar se arquivo contém string");
        Console.WriteLine ("8: Imprimir 10 primeiros digitos");
        Console.WriteLine ("9: Área de um retângulo");
        Console.WriteLine ("10: Soma de valores de um arquivo");

        Console.WriteLine ("Digite o número do exercício que deseja executar: ");
        int AtividadeTres = int.Parse(Console.ReadLine());

        switch (AtividadeTres)
        {
            case 1:
                Console.WriteLine ("Digite o valor da tabuada: ");
                int tabuada = int.Parse(Console.ReadLine());
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();
                StreamWriter arquivo = new StreamWriter(nomeArquivo);
                for (int i = 0; i <= 10; i++)
                {
                    arquivo.WriteLine(tabuada + " x " + i + " = " + (tabuada * i));
                }
                arquivo.Close();
                break;

            case 2:
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo2 = Console.ReadLine();
                StreamReader arquivo2 = new StreamReader(nomeArquivo2);
                string linha = arquivo2.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = arquivo2.ReadLine();
                }
                arquivo2.Close();
                break;

            case 3:
                Console.WriteLine ("Digite o primeiro valor: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine ("Digite o segundo valor: ");
                int valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine ("Digite o operador: ");
                string operador = Console.ReadLine();
                switch (operador)
                {
                    case "+":
                        Console.WriteLine (valor1 + valor2);
                        break;
                    case "-":
                        Console.WriteLine (valor1 - valor2);
                        break;
                    case "*":
                        Console.WriteLine (valor1 * valor2);
                        break;
                    case "/":
                        Console.WriteLine (valor1 / valor2);
                        break;
                    default:
                        Console.WriteLine ("Operador inválido");
                        break;
                }
                break;

            case 4:
                Console.WriteLine ("Digite o valor: ");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine ("Digite a potência: ");
                int potencia = int.Parse(Console.ReadLine());
                int resultado = 1;
                for (int i = 0; i < potencia; i++)
                {
                    resultado *= valor;
                }
                Console.WriteLine (resultado);
                break;

            case 5:
                string[] nomes = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine ("Digite o nome: ");
                    nomes[i] = Console.ReadLine();
                }
                Random random = new Random();
               
                for (int i = 0; i < 5; i++)
                {
                    int indice = random.Next(0, 5);
                    string nome = nomes[indice];
                    Console.WriteLine (nome);
                }
                break;

            case 6:
                Console.WriteLine ("Digite o raio: ");
                double raio = double.Parse(Console.ReadLine());
                double circunferencia = 2 * Math.PI * raio;
                double area = Math.PI * Math.Pow(raio, 2);
                Console.WriteLine ("Circunferência: " + circunferencia);
                Console.WriteLine ("Área: " + area);

                break;

            case 7:
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo3 = Console.ReadLine();
                StreamReader arquivo3 = new StreamReader(nomeArquivo3);
                string linha2 = arquivo3.ReadLine();
                while (linha2 != null)
                {
                    if (linha2.Contains("JAVA"))
                    {
                        Console.WriteLine ("Contém a string JAVA");
                        break;
                    }
                    linha2 = arquivo3.ReadLine();
                }
                arquivo3.Close();
                break;

            case 8:
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo4 = Console.ReadLine();
                StreamReader arquivo4 = new StreamReader(nomeArquivo4);
                string linha3 = arquivo4.ReadLine();
                while (linha3 != null)
                {
                    if (linha3.Length > 10)
                    {
                        Console.WriteLine (linha3.Substring(0, 10));
                    }
                    else
                    {
                        Console.WriteLine (linha3);
                    }
                    linha3 = arquivo4.ReadLine();
                }
                arquivo4.Close();
                break;

            case 9:
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo5 = Console.ReadLine();
                StreamReader arquivo5 = new StreamReader(nomeArquivo5);
                string linha4 = arquivo5.ReadLine();
                while (linha4 != null)
                {
                    if (linha4.Contains("JAVA"))
                    {
                        Console.WriteLine (linha4.Replace("JAVA", "C#"));
                    }
                    else
                    {
                        Console.WriteLine (linha4);
                    }
                    linha4 = arquivo5.ReadLine();
                }
                arquivo5.Close();
                break;

            case 10:
                Console.WriteLine ("Digite o nome do arquivo: ");
                string nomeArquivo6 = Console.ReadLine();
                StreamReader arquivo6 = new StreamReader(nomeArquivo6);
                string linha5 = arquivo6.ReadLine();
                while (linha5 != null)
                {
                    if (linha5.Contains("JAVA"))
                    {
                        Console.WriteLine (linha5.Replace("JAVA", "C#"));
                    }
                    else
                    {
                        Console.WriteLine (linha5);
                    }
                    linha5 = arquivo6.ReadLine();
                }
                arquivo6.Close();
                break;



            default:
                Console.WriteLine ("Opção inválida");
                break;
        }
    }
}




    //1) Crie um programa que receba um valor e calcule a tabuada deste valor, salvando seu resultado em um arquivo de texto. 
    //2) Crie um programa que leia e imprima no console todas as linhas de um arquivo de texto. 
    //3) Crie um programa que receba como entrada da classe Main dois valores numéricos e calcule as operações básicas com eles. 
    //4) Crie um programa que execute uma operação de Exponenciação com o valor inteiro com precisão arbitrária. 
    //5) Crie um programa que receba o nome de 5 pessoas e aleatorize eles. 
    //6) Crie um programa que calcule o raio e a área de uma circunferência (C = 2πr e A = π(r²)). 
    //7) Crie um programa que avalie se um arquivo de texto possui a string "JAVA". 
    //8) Crie um programa que leia as linhas de um arquivo e imprima no console apenas os 10 primeiros digitos de cada linha.
    // 9) Crie um programa que receba como entrada da classe Main dois valores numéricos e calcule a área dos valores (area = lado1 * lado2).
    // 10) Crie um programa que receba como entrada da classe Main o nome de um arquivo de texto que contenha valores numéricos e some todos os valores, imprimindo no console a soma.