using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite um numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int res = n1 + n2;

        Console.WriteLine("A soma dos dois numeros e: " + res);
    }
}