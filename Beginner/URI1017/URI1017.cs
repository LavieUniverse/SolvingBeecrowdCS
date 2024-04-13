/*Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.

Entrada
O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média durante a mesma (em km/h).

Saída
Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal*/

using System;

public class URI1017
{
	public URI1017()
	{
        static void Main(string[] args)
        {
            //Declarando os tipos de variáveis
            int t, s, vm;
            double consumo;

            //Armazenando os dados da entrada e convertendo para o tipo "int"
            t = int.Parse(Console.ReadLine());
            vm = int.Parse(Console.ReadLine());

            s = t * vm;
            consumo = s / 12.0;

            //Imprimindo o resultado da divisão na variável "consumo" com três casas decimais
            Console.WriteLine(consumo.ToString("0.000"));
        }
    }
}
