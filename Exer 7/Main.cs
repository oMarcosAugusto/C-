using System;

class Program { 
    static void Main() {
        Console.WriteLine("Quanto voce ganha por hora?: ");
        double value = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Quantas horas voce trabalha no mes?: ");
         double hrsWorked = Convert.ToDouble(Console.ReadLine());

         double res =  value * hrsWorked;

         Console.WriteLine("O seu salario sera de: " + res);
    }
}