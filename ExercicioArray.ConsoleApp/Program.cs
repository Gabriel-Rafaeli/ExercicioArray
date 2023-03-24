using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ExercicioArray
{
    public class Program
    {


        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Digite o {i} valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Menu(); 
        }

        static int[] valores = new int[10];
        static void Menu()
        {
            char opcao = '0';

            while (opcao != 'S')
            {
                Console.WriteLine();
                Console.WriteLine("Digite: ");
                Console.WriteLine("(1) Encontrar maior valor: ");
                Console.WriteLine("(2) Encontrar menor valor: ");
                Console.WriteLine("(3) Encontrar 3 maiores valores: ");
                Console.WriteLine("(4) Encontrar valores negativos: ");
                Console.WriteLine("(5) Mostrar os numeros em sequencia: ");
                Console.WriteLine("(6) Encontrar a média: ");
                Console.WriteLine("(7) Zerar um valor: ");
                Console.WriteLine("(S) Para sair: ");

                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        EncontrarMaiorValor(valores);
                        break;

                    case '2':
                        EncontrarMenorValor(valores);
                        break;

                    case '3':
                        Encontrar3MaioresValores(valores);
                        break;

                    case '4':
                        EncontrarValoresNegativos(valores);
                        break;

                    case '5':
                        MostrarSequencia(valores);
                        break;

                    case '6':
                        EncontrarValorMedio(valores);
                        break;

                    case '7':
                        RemoverValor(valores);
                        break;

                    case 'S':
                        break;
                }
            }
        }
        static void EncontrarValorMedio(int[] valor)
        {

            double somaDosValores = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                somaDosValores += valores[i];
            }
            Console.WriteLine();
            Console.WriteLine("A média dos valores é: " + somaDosValores / valores.Length);
        }
        static void EncontrarMaiorValor(int[] valor)
        {
            Array.Sort(valores);
            int maiorValor = valores[9];
            Console.WriteLine();
            Console.WriteLine("O maior valor é: " + maiorValor);
        }
        static void EncontrarMenorValor(int[] valor)
        {
            Array.Sort(valores);
            int menorValor = valores[0];
            Console.WriteLine();
            Console.WriteLine("O menor valor é: " + menorValor);
        }
        static void Encontrar3MaioresValores(int[] valor)
        {
            Array.Sort(valores);
            int maior = valores[9];
            int segundoMaior = valores[8];
            int terceiroMaior = valores[7];

            Console.WriteLine();
            System.Console.WriteLine("O maior valor é: " + maior);
            System.Console.WriteLine("O segundo maior valor é: " + segundoMaior);
            System.Console.WriteLine("O terceiro maior valor é: " + terceiroMaior);
        }
        static void EncontrarValoresNegativos(int[] valor)
        {
            Console.WriteLine();
            System.Console.Write("Os Valores negativos são: ");

            for (int i = 0; i < 10; i++)
            {
                if (valores[i] < 0)
                {
                    System.Console.Write(valores[i] + ", ");
                }
            }
        }
        static void MostrarSequencia(int[] valor)
        {
            Array.Sort(valores);
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.WriteLine(valores[9]);
            Console.WriteLine(valores[8]);
            Console.WriteLine(valores[7]);
            Console.WriteLine(valores[6]);
            Console.WriteLine(valores[5]);
            Console.WriteLine(valores[4]);
            Console.WriteLine(valores[3]);
            Console.WriteLine(valores[2]);
            Console.WriteLine(valores[1]);
            Console.WriteLine(valores[0]);
        }
        static void RemoverValor(int[] valor)
        {
            Console.WriteLine("Digite um valor para remover: ");
            int valorRemovido = int.Parse(Console.ReadLine());


            for (int i = 0; i < valores.Length; i++)
            {
                if (valorRemovido == valores[i])
                {
                    valores[i] = 0;
                }
            }
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"{valores[i]}  ");
            }
        }

    }
}