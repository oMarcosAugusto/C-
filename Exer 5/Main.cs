using System;

class Program {
    static void Main() {

        Console.WriteLine("Digite a altura: ");
        int altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o comprimento: ");
        int comprimento = Convert.ToInt32(Console.ReadLine());
        int res = altura * comprimento;

        Console.WriteLine("A area do quadrilatero e: " + res);
    }
}