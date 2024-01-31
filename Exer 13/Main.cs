using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite um valor, podendo ele ser positivo ou negativo!");
        int num = Convert.ToInt32(Console.ReadLine());

        string result = VerificarPositivoNegativo(num);
        Console.WriteLine(result);
    }
    static string VerificarPositivoNegativo(int num) {
        if (num > 0) {
            return "positivo";
        } else if (num < 0) {
            return "negativo";
        } else {
            return "zero";
        }
    }
}