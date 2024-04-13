/*Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
o valor que recebe por hora e calcula o salário desse funcionário.
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número,
quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade.
No caso do salário, também deve haver um espaço em branco após o $.*/

using System;

public class URI1008
{
	public URI1008()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos os tipos para as variáveis que usaremos, como pedido no enunciado:
            int n, h;
            double moneyPerHour;
            decimal salary;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método ".Parse()" para converter a string, inserida no console, em nos tipos, já definimos anteriormente, que será armazenado nas variáveis.
            n = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            moneyPerHour = double.Parse(Console.ReadLine());

            //Para obtermos o valor total do salário faremos a seguinte operação
            //No entanto, devemos converter explicitamente o tipo da variável "moneyPerHour" antes de multiplicar pela variável "h", para não haver erros, por meio do método "Convert.ToDecimal()"
            salary = h * Convert.ToDecimal(moneyPerHour);

            //Para retornar o resultado esperado utilizaremos duas vezes o método ".WriteLine()" da classe "Console":
            //1º para imprimir a string "NUMBER = " concatenando ao valor da variável "n".
            //2º para imprimir a string "SALARY = U$ " concatenando ao valor da variável "salary", convertendo o mesmo para uma string com duas casas decimais atráves do método ".ToString()".
            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + salary.ToString("0.00"));

        }

    }
}
