using System;

namespace Funcoes
{
    class Program
    {
        /*Escreva um programa que
     leia um vetor com 30 elementos inteiros e escreva funções para fazer o que se pede 
        (utilizar o vetor declarado globalmente)
a.Exibir os elementos do vetor na ordem inversa
b.Decompor em dois outros vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par
c.Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.*/
        
        

        









        //static double soma(double v1, double v2)
        //{
        //    double soma;
        //    soma = v1 + v2;
        //    //Console.WriteLine("A soma do resultados são: " + (soma = v1 + v2));
        //    return soma;
        //}
        //static double sub(double v1, double v2)
        //{
        //    double sub;
        //    sub = v1 - v2;
        //    //Console.WriteLine("A soma do resultados são: " + (sub = v1 - v2));
        //    return sub;
        //}
        //static double mult(double v1, double v2)
        //{
        //    double mult;
        //    mult = v1 * v2;
        //    //Console.WriteLine("A multiplicação do resultados são: " + (mult = v1 * v2));
        //    return mult;
        //}
        //static double divisao(double v1, double v2)
        //{
        //    double div;
        //    div = v1 / v2;
        //    // Console.WriteLine("A divisão do resultados são: " + (div = v1 / v2));
        //    return div;
        //}
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(" digite o elemento  " + (i + 1) + "  :  ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            exibirinverso(vetor);
            decompoeipar(vetor);
            decompoeiimpar(vetor);
            decomporpar(vetor);
            decomporimpar(vetor);




            //double v1, v2;
            //char op;
            //do
            //{
            //    Console.WriteLine("digite o valor:");
            //    v1 = double.Parse(Console.ReadLine());
            //    v2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o operador : + soma \n - subtrair \n * multiplicar \n / dividir \n Q Sair");
            //    op = char.Parse(Console.ReadLine());
            //    if ((((v2 == 0) || (v1 == 0)) && op == '/') || (op != '/') && (op != '*') && (op != '+') && (op != '-') && op != 'q')
            //    {
            //        Console.WriteLine("Operação inválida");
            //        continue;
            //    }
            //    if (op == 'q')
            //    {
            //        Console.WriteLine("APLICATIVO ENCERRADO COM SUCESSO! OBRIGADO");
            //        break;
            //    }
            //    switch (op)
            //    {
            //        case '+':
            //            Console.WriteLine("Resultado da soma = " + soma(v1, v2));
            //            break;
            //        case '-':
            //            Console.WriteLine("Resultado da subtração = " + sub(v1, v2));
            //            break;
            //        case '*':
            //            Console.WriteLine("Resultado da multiplicação = " + mult(v1, v2));
            //            break;
            //        case '/':
            //            Console.WriteLine("Resultado da divisão = " + divisao(v1, v2));
            //            break;
            //    }
            //} while (op != 'q');

        }

        private static void decomporimpar(int[] vetor)
        {
            int i, j = 0, ei = 0;
            int[] impar;
            for (i = 0; i < vetor.Length; i++)
                if (vetor[i] % 2 != 0)
                    ei++;

            impar = new int[ei];
            for (i = 0, j=0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    impar[j] = vetor[i];
                    j++;
                }
            }
            Console.WriteLine("Elementos pares: ");
            mostravetor(impar);
        }

        private static void decomporpar(int[] vetor)
        {
            int i,j = 0,p= 0;
            int[] par;
            for ( i = 0; i < vetor.Length; i++)
                if (vetor[i]%2==0)
                    p++;

            par = new int[p];
            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 ==0)
                {
                    par[j] = vetor[i];
                    j++;
                }
            }
            Console.WriteLine("Elementos pares: ");
            mostravetor(par);
        }

        private static void decompoeiimpar(int[] vetor)
        {
            int[] iimpar = new int[5];
            int i, j=0;
            for (i = 0; i < 5; i++)
            {
                if (i % 2 != 0)
                {

                iimpar[j] = vetor[i];
                j++;
                }
            }
            Console.WriteLine("mostra indicices impares: ");

            mostravetor(iimpar);
        }

        private static void mostravetor(int[] vetor)
        {
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(" digite o elemento  " + (i + 1) + "  :  " + vetor[i]);

            }
        }

        private static void decompoeipar(int[] vetor)
        {
            int[] ipar = new int[5];
            int i, j = 0;
            for (i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0)
                {

                    ipar[j] = vetor[i];
                    j++;
                }
            }
            Console.WriteLine("mostra indicices pares: ");
            mostravetor(ipar);

        }

        private static void exibirinverso(int[] vetor)
         {
            int i;
            for (i = 9; i >= 0; i--)
            {
            Console.WriteLine("elemento" + (i + 1) + " = " + vetor[i]);
            }
         }

    }

}
