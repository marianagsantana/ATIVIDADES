namespace atividade
{
    
}

internal class ListaSeis
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Exercicios:");
        Console.WriteLine("1: Gerenciamento de informações");
        Console.WriteLine("2: Informações salvas");
        Console.WriteLine("3: Controle de produtos");


        Console.WriteLine("Digite o número do exercício que deseja executar: ");
        int AtividadeSeis = int.Parse(Console.ReadLine());

        switch (AtividadeSeis)
        {
            case 1: 
                Console.WriteLine("Digite o número da informação que deseja gerenciar: ");
                Console.WriteLine("1: Nome e Nota do Aluno");
                Console.WriteLine("2: Nome e Conceito do Aluno");
                Console.WriteLine("3: Código e Nome do Funcionário");
                Console.WriteLine("4: Coordenadas X e Y de Localização");
                int gerenciamento = int.Parse(Console.ReadLine());

                switch (gerenciamento)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do aluno: ");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("Digite a nota do aluno: ");
                        double notaAluno = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do aluno: ");
                        string nomeAluno1 = Console.ReadLine();
                        Console.WriteLine("Digite o conceito do aluno: ");
                        string conceitoAluno = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Digite o código do funcionário: ");
                        int codigoFuncionario = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do funcionário: ");
                        string nomeFuncionario = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Digite a coordenada X: ");
                        int coordenadaX = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a coordenada Y: ");
                        int coordenadaY = int.Parse(Console.ReadLine());
                        break;

                }
                break;

            case 2:
                Console.WriteLine("Digite o número da informação que deseja imprimir: ");
                Console.WriteLine("1: Nome e Nota do Aluno");
                Console.WriteLine("2: Nome e Conceito do Aluno");
                Console.WriteLine("3: Código e Nome do Funcionário");
                Console.WriteLine("4: Coordenadas X e Y de Localização");
                int imprimir = int.Parse(Console.ReadLine());

                switch (imprimir)
                {
                    case 1:
                        Console.WriteLine("Nome do aluno: " + nomeAluno);
                        Console.WriteLine("Nota do aluno: " + notaAluno);
                        break;
                    case 2:
                        Console.WriteLine("Nome do aluno: " + nomeAluno);
                        Console.WriteLine("Conceito do aluno: " + conceitoAluno);
                        break;
                    case 3:
                        Console.WriteLine("Código do funcionário: " + codigoFuncionario);
                        Console.WriteLine("Nome do funcionário: " + nomeFuncionario);
                        break;
                    case 4:
                        Console.WriteLine("Coordenada X: " + coordenadaX);
                        Console.WriteLine("Coordenada Y: " + coordenadaY);
                        break;
                    default:
                }
                break;

            case 3:
                Console.WriteLine("Digite o ID do produto: ");
                int idProduto = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o código de rastreio do produto: ");
                string codigoRastreio = Console.ReadLine();

                break;
           
            default:

            Console.WriteLine("Digite um número válido");
            break;

        }

    }
} 


//

//Crie um programa que permita gerenciar quatro diferentes informações:

//Nome e Nota do Aluno
//Nome e Conceito do Aluno
//Código e Nome do Funcionário
//Coordenadas X e Y de Localização Para isso, deverá ser criada uma classe com comportamento genérico de chave e valor que permite o gerencimanto dessas informações.


//Utizando o programa anterior, na class genérica crie um método que receba as informações salvas e imprima o conteúdo dessas informações.

//Crie um programa para controle de produtos, onde cada produto deverá possuir a seguinte estrutura:

//ID
//Nome
//Código de Rastreio
//O código de rastreio é um código sequencial composto de 3 dígitos iniciais que representa o setor e 4 dígitos finais incrementais (Ex.: ALM0001, ALM0002, EXP0001). Deve ser criada uma classe com comprotamento genérico para geração desses códigos.

