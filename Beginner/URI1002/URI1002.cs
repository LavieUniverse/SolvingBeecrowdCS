/*ENUNCIADO DA QUESTÃO: A fórmula para calcular a área de uma circunferência é: area = π.raio2.
Considerando para este problema que π = 3.14159:
-Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.*/

using System;

public class URI1002
{
	public URI1002()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO
            //Neste exercício apenas usaremos variáveis do tipo double:
            double raio, pi = 3.14159;

            //A questão pede que a entrada seja um valor de ponto flutuante de dupla precisão, e que este valor seja armazenado na variável raio.
            //Para isso usaremos o método ".ReadLine()", da classe "Console" para solicitar a entrada de texto. E essa string deverá ser convertida em double antes de ser armazenada na variável.
            raio = double.Parse(Console.ReadLine());

            //E agora, adicionamos uma instrução para imprimir a cadeia de literais "A=" e o resultado da multiplicação (area do círculo = (pi * (raio * raio)))
            //Além disso, precisamos informar a máquina que retorne um número contendo 4 casas decimais, convertendo-o numa string, utilizando o método ".ToString()".
            Console.WriteLine("A=" + (pi * (raio * raio)).ToString("0.0000"));
        }
    }
}
