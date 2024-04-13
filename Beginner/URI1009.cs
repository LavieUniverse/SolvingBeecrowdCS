/*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês,
com duas casas decimais.

Entrada
O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais,
representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

Saída
Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.*/

using System;

public class URI1009
{
	public URI1009()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos os tipos das variáveis, como pedido no enunciado:
            double salario, vendas, comissao;
            string nome = Console.ReadLine();

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método ".Parse()" para converter a string, inserida no console, no tipo double, que será armazenado nas variáveis.
            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            //Armazenamos na variável "comissao" a operação para obter o valor da comissão
            comissao = vendas * 0.15;

            //Para obtermos o valor total do salário com a comissão podemos declarar uma variável "total = salario + comissao" ou imprimir diretamente o resultado
            //Para retornar o resultado da soma dos valores de "salario" e "comissao" utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "TOTAL = R$ " concatenando à soma dos valores das variável
            //E por fim, para retornarmos um valor com duas casas decimais utilizamos o método ".ToString("0.00")"
            Console.WriteLine("TOTAL = R$ " + (salario + comissao).ToString("0.00"));
        }
    }
}
