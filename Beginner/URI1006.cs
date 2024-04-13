/*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5.
Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".*/

using System;

public class URI1006
{
	public URI1006()
	{
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos o tipo double para as variáveis, como pedido no enunciado:
            double A, B, C, media;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método "Convert.ToDouble()" para converter a string, inserida no console, em um tipo double.
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            //Para obtermos a média ponderada dos valores armazenados em A, B e C inseridos no console pelos seus respectivos pesos, declaramos uma variável "media" contendo essa informação:
            mediaP = ((A * 2) + (B * 3) + (C * 5)) / 10;

            //Para retornar o resultado da multiplicação utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "MEDIA = " e o valor da variável "media".
            //Afim de retornar uma string no formato "0.0", pedido no enunciado, utilizamos o método ".ToString()" para converter o valor de "media" numa string com 1 casa decimal.

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
        }
    }
}
