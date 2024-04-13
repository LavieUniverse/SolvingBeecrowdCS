/*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
 Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".*/

using System;

public class URI1013
{
	public URI1013()
	{
        static void Main(string[] args)
        {
            //Declaração do tipos de dados
            int A, B, S, maior, maiorAB;
            string[] valores = Console.ReadLine().Split(' ');

            //Declarando as variáveis com os itens do vetor "valores" resultantes da entrada de dados e convertendo para "int"
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            S = int.Parse(valores[2]);

            //Aplicando a fórmula do enunciado
            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = (maiorAB + S + Math.Abs(maiorAB - S)) / 2;

            //Imprimindo o resultado desejado
            Console.WriteLine(maior + " eh o maior");

        }
    }
}
