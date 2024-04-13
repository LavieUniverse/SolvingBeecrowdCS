/*Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".*/

using System;

public class URI1014
{
	public URI1014()
	{
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int km = int.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());

            //Imprimindo o resultado da divisão com três casas decimais e a string "km/l" 
            Console.WriteLine((km / l).ToString("0.000") + " km/l");
        }
    }
}
