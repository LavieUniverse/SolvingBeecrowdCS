/*Leia quatro valores inteiros A, B, C e D.
A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada
O arquivo de entrada contém 4 valores inteiros.

Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.*/

using System;

public class URI1007
{
	public URI1007()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos o tipo inteiro para as variáveis, como pedido no enunciado:
            int A, B, C, D;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método ".Parse()" para converter a string, inserida no console, em um tipo inteiro, que será armazenado nas variáveis.
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            //Para obtermos a diferença dos valores armazenados em A, B, C e D inseridos no console, poderiamos declarar uma variável "diferenca = (A * B) - (C * D)". Ou fazemos direto.
            //Para retornar o resultado da subtração utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "DIFERENCA = " e o valor da variável "diferenca" ou podemos colocar a expressão.
            Console.WriteLine("DIFERENCA = " + ((A * B) - (C * D)));
        }
    }
}
