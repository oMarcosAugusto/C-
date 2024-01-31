using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite um número: ");
        
        string numString = Console.ReadLine();
        int num;
        double num2;

        if (int.TryParse(numString, out num)) {
            Console.WriteLine("O número " + num + " é um inteiro e possui " + numString.Length + " dígitos.");
        } else if (double.TryParse(numString, out num2)) {
            Console.WriteLine("O número " + numString + " é um decimal e possui " + numString.Length + " caracteres.");
        } else {
            Console.WriteLine("Entrada inválida.");
        }
    }
}
