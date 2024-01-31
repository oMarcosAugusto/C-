using System;

class Program { 
    static void Main() {
        Console.WriteLine("Digite 2 numeros inteiros e 1 numero real: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        double n3 = Convert.ToDouble(Console.ReadLine());

        double res = (n1 * 2 ) + (n2 /2);

        Console.WriteLine("O valor do dobro do primeiro com a metade do segundo e: " + res);

        double res2 = (n1 * 3) + n3;

        Console.WriteLine("A soma do triplo do primeiro com o terceiro e: " + res2);

        double res3 = Math.Pow(n3, 3);

        Console.WriteLine("O valor do terceiro elevado ao cubo e: " + res3);
    }
}