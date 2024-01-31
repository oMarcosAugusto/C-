using System;

class Program {
    static void Main() {
        init:
        Console.WriteLine("Digite o ano: ");
        string ano = Console.ReadLine();

        int numAno;

         if (int.TryParse(ano, out numAno)) {
            if (numAno % 4 == 0) {
                Console.WriteLine("Esse ano e bissexto");
            } else {
                Console.WriteLine("Esse ano nao e bissexto");
            }
        }
        else {
            Console.WriteLine("O valor inserido não e válido");
            goto init;
        }
    }
}