/*Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.

Entrada
O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

Saída
A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.*/

using System;

public class URI1011
{
	public URI1011()
	{
        static void Main(string[] args)
        {
            //Declaração dos tipos de dados
            double r, pi = 3.14159;

            //Declarando "r" com uma valor informado no console
            //O método ".ReadLine()" da classe "Console" permite uma entrada de dados correspondente ao valor de r
            //O método ".Parse()" converte a entrada do tipo string
            //"double" é uma indicação para a conversão operada pelo método ".Parse()"
            r = double.Parse(Console.ReadLine());

            //Imprimindo o resultado desejado:
            //Sendo a fórmula do volume da esfera 4/3 * pi * r³, temos:
            Console.WriteLine("VOLUME = " + ((4.0 / 3) * (pi) * (r * r * r)).ToString("0.000"));

        }
    }
}
