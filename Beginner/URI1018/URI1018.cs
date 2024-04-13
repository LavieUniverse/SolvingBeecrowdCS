/*Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.*/

using System;

public class URI1018
{
	public URI1018()
	{
        static void Main(string[] args)
        {
            //Declaração dos tipos de dados
            int N, quociente, resto, nota;

            //Atribuindo a variável o valor fornecido no console
            N = int.Parse(Console.ReadLine());

            //Imprime o valor de N
            Console.WriteLine(N);

            //Atribui N à variável resto
            resto = N;

            //Sendo 100 a nota, encontra o resultado da divisão, imprime o número de notas de 100
            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            
            //Encontra o resto
            resto = resto % nota;

            //Sendo 50 a nota, encontra um quociente, imprime o número de notas de 50
            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            
            //Encontra o resto
            resto = resto % nota;


            //Sendo 20 a nota, encontra o quociente da divisão, imprime o número de notas de 20
            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            
            //Encontra o resto
            resto = resto % nota;

            //Sendo 10 a nota, encontra o número de notas e imprime a quantidade de notas de 10
            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

            //Encontra o resto
            resto = resto % nota;


            //Sendo notas de 5, encontra o quociente e imprime este número como a quantidade de notas de 5
            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            
            //Encontra o resto
            resto = resto % nota;

            //Sendo as notas de 2, encontra a quatidade de notas e imprime
            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

            //Encontra o resto
            resto = resto % nota;

            //E o resto será o número de notas de 1
            Console.WriteLine(resto + " nota(s) de R$ 1,00");
        }
    }
}
