
namespace atividade
{
    
}
internal class ListaQuatro
{
    public static void Main(string[] args)
    {

    Console.WriteLine ("Exercicios:");
    Console.WriteLine ("1: Cálculo de média");
    Console.WriteLine ("2: Array com Foreach");
    Console.WriteLine ("3: Array");
    Console.WriteLine ("4: Par ou ímpar");
    Console.WriteLine ("5: Cartas do baralho");
    Console.WriteLine ("6: Unir duas listas");
    Console.WriteLine ("7: Fila de atendimento");
    Console.WriteLine ("8: Temperatura média");
    Console.WriteLine ("9: Array intercalado");
    Console.WriteLine ("10: Valores inferiores a média");

    Console.WriteLine ("Digite o número do exercício que deseja executar: ");
    int AtividadeQuatro = int.Parse(Console.ReadLine());

    switch (AtividadeQuatro)
    {
        case 1:
            Console.WriteLine ("Digite a quantidade de notas: ");
            int quantidade = int.Parse(Console.ReadLine());
            double[] notas = new double[quantidade];
            double soma = 0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine ("Digite a nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }
            double media = soma / quantidade;
            Console.WriteLine ("A média é: " + media);
            break;

        case 2:
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int i in array)
            {
                Console.WriteLine (i);
            }
            break;

        case 3:
            double[] array2 = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + ": ");
                array2[i] = double.Parse(Console.ReadLine());
            }
            foreach (double i in array2)
            {
                Console.WriteLine (i);
            }
            break;

        case 4:
            int[] array3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + ": ");
                array3[i] = int.Parse(Console.ReadLine());
                if (array3[i] % 2 == 0)
                {
                    Console.WriteLine ("O valor " + array3[i] + " é par.");
                }
                else
                {
                    Console.WriteLine ("O valor " + array3[i] + " é ímpar.");
                }
            }
            break;

        case 5:
            string[] baralho = {"Ás de Copas", "2 de Copas", "3 de Copas", "4 de Copas", "5 de Copas", "6 de Copas", "7 de Copas", "8 de Copas", "9 de Copas", "10 de Copas", "Valete de Copas", "Dama de Copas", "Rei de Copas", "Ás de Espadas", "2 de Espadas", "3 de Espadas", "4 de Espadas", "5 de Espadas", "6 de Espadas", "7 de Espadas", "8 de Espadas", "9 de Espadas", "10 de Espadas", "Valete de Espadas", "Dama de Espadas", "Rei de Espadas", "Ás de Ouros", "2 de Ouros", "3 de Ouros", "4 de Ouros", "5 de Ouros", "6 de Ouros", "7 de Ouros", "8 de Ouros", "9 de Ouros", "10 de Ouros", "Valete de Ouros", "Dama de Ouros", "Rei de Ouros", "Ás de Paus", "2 de Paus", "3 de Paus", "4 de Paus", "5 de Paus", "6 de Paus", "7 de Paus", "8 de Paus", "9 de Paus", "10 de Paus", "Valete de Paus", "Dama de Paus", "Rei de Paus"};
            Random random = new Random();
            int numero = random.Next(0, 51);
            Console.WriteLine ("A carta sorteada é: " + baralho[numero]);
            break;

        case 6:
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            List<int> lista3 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + " da lista 1: ");
                lista1.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine ("Digite o valor " + (i + 1) + " da lista 2: ");
                lista2.Add(int.Parse(Console.ReadLine()));
            }
            lista3.AddRange(lista1);
            lista3.AddRange(lista2);
            foreach (int i in lista3)
            {
                Console.WriteLine (i);
            }
            break;

        case 7:
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Joseph");
            fila.Enqueue("Maria");
            fila.Enqueue("Mariana");
            fila.Enqueue("Edward");
            fila.Enqueue("Marcelo");
            fila.Enqueue("Patricia");
            fila.Enqueue("Celio");
            fila.Enqueue("Jamily");
            fila.Enqueue("Rafael");
            fila.Enqueue("Ricardo");
            Console.WriteLine ("Fila de atendimento: ");
            foreach (string i in fila)
            {
                Console.WriteLine (i);
            }
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            Console.WriteLine ("Atendendo: " + fila.Dequeue());
            break;

        case 8:
            double[] temperatura = new double[12];
            double soma2 = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine ("Digite a temperatura média do mês " + (i + 1) + ": ");
                temperatura[i] = double.Parse(Console.ReadLine());
                soma2 += temperatura[i];
            }
            double media2 = soma2 / 12;
            Console.WriteLine ("A temperatura média do ano é: " + media2);
            break;

        case 9:
            int[] array4 = new int[10];
            int[] array5 = new int[10];
            int[] array6 = new int[20];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + " do primeiro array: ");
                array4[i] = int.Parse(Console.ReadLine());
                Console.WriteLine ("Digite o valor " + (i + 1) + " do segundo array: ");
                array5[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                array6[i] = array4[i];
                array6[i + 10] = array5[i];
            }
            foreach (int i in array6)
            {
                Console.WriteLine (i);
            }
            break;

        case 10:
            List<string> lista4 = new List<string>();
            List<string> lista5 = new List<string>();
            List<string> lista6 = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + " da lista 1: ");
                lista4.Add(Console.ReadLine());
                Console.WriteLine ("Digite o valor " + (i + 1) + " da lista 2: ");
                lista5.Add(Console.ReadLine());
            }
            lista6.AddRange(lista4);
            lista6.AddRange(lista5);
            foreach (string i in lista6)
            {
                Console.WriteLine (i);
            }
            break;

        default:
            Console.WriteLine ("Opção inválida");
            break;

    }
}
}

    

//1) Crie um programa que questione a quantidade de notas a ser informada, receba as notas e calcule a média. 
//2) Crie um programa que imprima um arrays com Foreach. 
//3) Crie um programa que leia 10 valores double e salve em um array, depois imprima esses valores. 
//4) Crie um programa que leia 10 valores int e salve em um array, depois imprima se esses valores são pares ou ímpares. 
//5) Crie um programa que possua uma collection que represente as 52 cartas do baralho, imrpima elas. 
//6) Crie um programa que una duas listas de inteiros. 
//7) Crie um programa que simule a fila de atendimento de um banco.
// 8) Crie um programa que receba a temperatura média de cada mês do ano e após exiba a temperatura média do ano.
// 9) Crie dois arrays de 10 posições e depois gere um terceiro array com os valores intercalados desses dois arrays, ao final, imprima os 3.
// 10) Crie um programa que leia 20 valores, calcule a média aritmética desses valores e imprima os valores que são inferiores a esta média.