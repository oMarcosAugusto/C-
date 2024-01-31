using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite dois numeros: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        int res = Math.Max(n1 , n2);

        Console.WriteLine("O maior valor entre os dois numeros e o: " + res);
    }
}