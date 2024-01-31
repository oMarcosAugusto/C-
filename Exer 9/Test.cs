using System;

class Program { 
    static void Main() {
        Console.WriteLine("Digite um numero inteiro: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um numero real: ");      
        double n2 = Convert.ToDouble(Console.ReadLine());

        double n3 = (n1 * 2 ) + (n2 /2);
        double n4 = (n1 * 3) + n3;
        double rn5 = Math.Pow(n3, 3);

        Console.WriteLine(n3+ " " + n4 + " " + n5);
    }
}