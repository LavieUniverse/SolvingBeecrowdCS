/*Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 2 valores com uma casa decimal cada um.

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double) e como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".*/

using System;

public class URI1005
{
    public URI1005()
    {
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos o tipo double para as variáveis, como pedido no enunciado:
            double A, B, media;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método "Convert.ToDouble()" para converter a string, inserida no console, em um tipo double. 
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());

            //Para obtermos a média ponderada dos valores armazenados em A e B inseridos no console pelos seus respectivos pesos, declaramos uma variável "media" contendo essa informação:

            media = ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);

            //Para retornar o resultado da multiplicação utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "MEDIA = {0}" formatando-a com o método "String.Format()" para que "{0}" seja substituído pelo valor da variável "media".
            //Afim de retornar uma string o formato "0.00000", pedido no enunciado, utilizamos o método ".ToString()" para converter o valor de "media" numa string com 5 casas decimais.
            Console.WriteLine("MEDIA = {0}", media.ToString("0.00000"));

        }
    }
}
