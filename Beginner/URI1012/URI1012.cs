/*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.*/

using System;

public class URI1012
{
	public URI1012()
	{
        static void Main(string[] args)
        {
            //Declaração dos tipos de dados
            double A, B, C, pi = 3.14159;

            //Declaração de uma variável contendo um vetor que armazena dados digitados no console
            string[] n = Console.ReadLine().Split(' ');
            
            //Armazenando as informações da entrada de dados em outras variáveis, e convertendo o tipo de dado
            A = double.Parse(n[0]);
            B = double.Parse(n[1]);
            C = double.Parse(n[2]);

            //Aplicando os cálculos de área para serem imprimidos com três casas decimais
            //O método ".WriteLine()" imprime e o método ".ToString()" define a quantidade de casas decimais
            Console.WriteLine("TRIANGULO: " + ((A * C) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO: " + ((C * C) * pi).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + (((A + B) / 2.0) * C).ToString("0.000"));
            Console.WriteLine("QUADRADO: " + (B * B).ToString("0.000"));
            Console.WriteLine("RETANGULO: " + (B * A).ToString("0.000"));
        }
    }
}
