/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos: segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos: segundos, conforme exemplo fornecido.*/

using System;

public class URI1019
{
	public URI1019()
	{
        static void Main(string[] args)
        {
            //Declarando os tipos de dados
            int N, horas, resto, minutos, segundos;

            //Armazenando na variável o dado da entrada
            N = int.Parse(Console.ReadLine());

            //As operações para obter a resposta
            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            //Imprimindo o resultado desejado
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
