/*Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.*/

using System;

public class URI1020
{
	public URI1020()
	{
        static void Main(string[] args)
        {
            //Declarando os tipos de dados
            int idade, meses, restoAnos, dias, anos;

            //Armazenando na variável o dado da entrada
            idade = int.Parse(Console.ReadLine());

            //As operações para obter a resposta
            anos = idade / 365;
            restoAnos = idade % 365;

            meses = restoAnos / 30;
            dias = restoAnos % 30;

            //Imprimindo o resultado desejado
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
