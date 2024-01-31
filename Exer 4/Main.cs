using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite a metragem a ser convertida para centimetros: ");        
        int n1 = Convert.ToInt32(Console.ReadLine());
        int res = n1 * 100;

        Console.WriteLine("O resultado e: " + res + "cm");
    }
}