/*Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.*/

using System;

public class URI1010
{
	public URI1010()
	{
        static void Main(string[] args)
        {
            //Inicialmente é necessário declarar os tipos das variáveis que usaremos:
            int cod1, cod2, n1, n2;
            double preco1, preco2, total;

            //Na sequência, criaremos uma array para armazenar as informações digitadas no console:
            //Para criar uma array primeiro declaramos uma variável "compra" que armazenará uma array do tipo string "string[]"
            //Neste caso, queremos uma entrada de dados e para isso usaremos o método "Console.Readline()".
            //Para o computador entender que os dados da entrada pertencem a diferentes variáveis informaremos por meio do método ".Split()", que resulta numa array string, uma separação com espaço "(" ")".
            string[] compra = Console.ReadLine().Split(' ');
            
            //Armazenando as informações da primeira compra a partir de cada item da array em uma variável e convertendo de string para o tipo de dado desejado para a mesma.
            cod1 = int.Parse(compra[0]);
            n1 = int.Parse(compra[1]);
            preco1 = double.Parse(compra[2]);

            //Solucitando uma segunda entrada de dados contendo as informações da segunda compra
            compra = Console.ReadLine().Split(' ');

            //Armazenando as informações da segunda compra a partir de cada item da array em uma variável e convertendo de string para o tipo de dado desejado para a mesma.
            cod2 = int.Parse(compra[0]);
            n2 = int.Parse(compra[1]);
            preco2 = double.Parse(compra[2]);

            //Para calcular o total multiplicaremos a quantidade do produto cod1 pelo seu preço, e somar o resultado a multiplicação da quantidade do produto cod2 pelo seu preço
            total = (n1 * preco1) + (n2 * preco2);

            //Para imprimir na tela a string "VALOR A PAGAR: R$ " e o resultado das operações mateméticas da variável "total" contendo duas casas decimais
            //Usaremos o método "Write.Line()" contendo a cadeia de literais "VALOR A PAGAR: R$ ", contatenando(+) a variável "total" seguida do método ".ToString("0.00"), que define a representação de uma string com duas casas decimais.
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("0.00"));

        }
    }
}
