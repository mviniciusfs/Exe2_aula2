using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Digite um Número: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("O número digitado foi: " + n);
  }
}