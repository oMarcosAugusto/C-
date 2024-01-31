using System;

class Program {
    static void Main() {
        Console.WriteLine("Qual o tamanho em metros quadrado da area a ser pintada?: ");
        double areaQuadrada = Convert.ToDouble(Console.ReadLine());

        double latas = Math.Ceiling(areaQuadrada / 54);
        double price = latas * 80.00;

        Console.WriteLine("Sao precisas " + latas + " latas, e o valor sera: " + "R$" + price);
    }
}