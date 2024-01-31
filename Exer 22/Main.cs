using System;

class Program {
    static void Main() {
        init:
        Console.WriteLine("Digite uma nota entre 0 e 10: ");

        string nota = Console.ReadLine();

        int res;

        if(int.TryParse(nota, out res) && res <= 10) {
            Console.WriteLine("A nota digitada foi {0}", res);
        } else {
            Console.WriteLine("Valor incorreto! ");
            goto init;
        }
    }
}

