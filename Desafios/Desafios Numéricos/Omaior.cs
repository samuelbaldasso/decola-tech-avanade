/*
Desafio

Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar 
a mensagem “ eh o maior”. Use a seguinte forma como base:

MaiorAB = (a+b+abs(a-b))/2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
Entrada

O arquivo de entrada contém três valores inteiros.
Saída

Imprima o maior dos três valores seguido pela mensagem " eh o maior".

Exemplos de Entrada 	Exemplos de Saída

7 14 106                106 eh o maior

217 14 6                217 eh o maior
*/
using System;

class Program {
  static void Main(string[] args) {
    string[] vet = Console.ReadLine().Split(' ');
    int a = Convert.ToInt32(vet[0]);
    int b = Convert.ToInt32(vet[1]);
    int c = Convert.ToInt32(vet[2]);
    int MAIOR = 0;

    if (a >= b && a >= c) {
      MAIOR = a;
    } else if(b >= a && b >= c) {
      MAIOR = b;
    } else {
      MAIOR = c;
    }

    Console.WriteLine($"{MAIOR} eh o maior");
  }
}