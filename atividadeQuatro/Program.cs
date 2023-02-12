
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

        case 5: //COLLECTION 52 CARTAS DE BARALHO




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

        case 10: // 20 VALORES , CALCULE A MEDIA E IMPRIMA OS VALORES INFERIORES A MEDIA
            double[] array7 = new double[20];
            double soma3 = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine ("Digite o valor " + (i + 1) + ": ");
                array7[i] = double.Parse(Console.ReadLine());
                soma3 += array7[i];
            }
            double media3 = soma3 / 20;
            Console.WriteLine ("A média é: " + media3);
            for (int i = 0; i < 20; i++)
            {
                if (array7[i] < media3)
                {
                    Console.WriteLine ("O valor " + array7[i] + " é inferior a média.");
                }
            }
            break;            

        default:
            Console.WriteLine ("Opção inválida");
            break;

    }
}
}

    