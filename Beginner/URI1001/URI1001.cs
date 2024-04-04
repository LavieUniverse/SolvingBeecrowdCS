/*ENUNCIADO DA QUESTÃO: Leia 2 valores inteiros e armazene-os nas variáveis A e B.
Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X conforme
exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo
especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário,
você receberá "Presentation Error".*/

using System;

public class URI1001
{
	public URI1001()
    {
        static void Main(string[] args)
        {
            //RESOLUÇÃO
            //Primeiramente vamos tipificar as variáveis A, B e X que serão usadas
            //E o enunciado já nos informa que se tratam de variáveis do tipo inteiro.
            int A, B, X;

            //Entradas: Serão dois números inteiros.
            //1. Usaremos o método ".ReadLine()", da classe "Console", para permite que o usuário digite os dados.
            //Porém, o método utilizado lê uma linha de texto da entrada do usuário retornando uma String
            //No entanto, as variáveis utilizadas são do tipo Inteiro, e só podem armazenar este tipo de dado.
            //Para converte a String retornada em Inteiro utilizando o método "int.Parse()".
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            //2. O enunciado pede para armazenar a soma de A e B em X:
            X = A + B;

            //3. Para obter a saída desejada utilizaremos o método ".WriteLine()", da classe "Console" para imprimir
            //A uma linha de texto contendo a cadeia de catacteres "X = " e o valor da soma de A e B armazenados na variável "X".
            //Para imprimir a string e o valor da variável em uma única linha de texto será necessário usar a operação de concatenação "+".
            Console.WriteLine("X = " + X);
        }
    }
}
