using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite sua altura: ");
        double alt = Convert.ToDouble(Console.ReadLine());

        int res = (int)(72.7 * alt) -58;

        Console.WriteLine("O peso ideal e: " + res);
    }
}