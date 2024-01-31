using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite o valor do raio do circulo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double areaE1 = Math.PI * Math.Pow(raio, 2);
        double areaE2 = Math.PI * (raio * raio);

        Console.WriteLine("A área do círculo é: " + areaE1);
        Console.WriteLine("A área arredondada é: " + Math.Round(areaE2));
    }
}