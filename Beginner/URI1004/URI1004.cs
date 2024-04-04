/*Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.*/

using System;

public class URI1004
{
    public URI1004()
    {
        static void Main(string[] args)
        {
            //RESOLUÇÃO: Primeiro definimos o tipo inteiro para as variáveis, como pedido no enunciado:
            int x, y, prod;

            //Para armazenar os valores digitados no console nas suas rescpecitivas variáveis usaremos o método".ReadLine()" da classe "Console"
            //Lembrando que o "ReadLine" sempre lê os dados como uma cadeia de caracteres literais, uma string.
            //Utilizando o método ".Parse()" para converter a string, inserida no console, em um tipo int.  
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            //Para obtermos a multiplicação dos valores armazenados em X e Y inseridos declaramos uma variável "prod" contendo essa informação:
            prod = x * y;

            //Para retornar o resultado da multiplicação utilizamos o método ".WriteLine()" da classe "Console" para imprimir a string "PROD = " e o valor da variável "prod".
            Console.WriteLine("PROD = " + prod);

        }
    }
}
