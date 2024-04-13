/*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
 Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.*/

using System;

public class URI1015
{
	public URI1015()
	{
        static void Main(string[] args)
        {
            //Declarando os tipos de dados
            double x1, x2, y1, y2;

            //Criando uma entrada de dados para armazenar no vetor "p1" as coordenadas informadas referente ao ponto 1 
            string[] p1 = Console.ReadLine().Split(' ');
            //Armazenando em x1 o dado da primeira posição de p1, e convertendo para double
            x1 = double.Parse(p1[0]);
            //Armazenando em y1 o dado da segunda posição de p1, e convertendo para double
            y1 = double.Parse(p1[1]);

            //Criando uma nova entrada de dados para armazenar no vetor "p2" as coordenadas referentes ao ponto 2 
            string[] p2 = Console.ReadLine().Split(' ');
            //Armazenando em x2 o dado da primeira posição de p2, e convertendo para double
            x2 = double.Parse(p2[0]);
            //Armazenando em y2 o dado da primeira posição de p2, e convertendo para double
            y2 = double.Parse(p2[1]);

            //Imprimindo o resultado da fórmula com quatro casas decimais
            Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0)).ToString("0.0000"));


        }
    }
}
