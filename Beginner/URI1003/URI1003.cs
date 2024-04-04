/*Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
A seguir escrever o valor desta variável.

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor
correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário,
você receberá "Presentation Error".*/

using System;

public class URI1003
{
	public URI1003()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos o tipo inteiro para as variáveis, como pedido no enunciado:
            int A, B, soma;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre interpreta os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método ".Parse()" para converter a string, inserida no console, em um tipo int.  
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            //Para obtermos a soma dos dados inseridos declaramos uma variável "soma" contendo essa informação:
            soma = A + B;

            //Para retornar o resultado da soma utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "SOMA = " e o valor da variável "soma".
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
