using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite 3 valores: ");
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        string n3 = Console.ReadLine();

        int num1;
        int num2;
        int num3;

        if (int.TryParse(n1, out num1) && int.TryParse(n2, out num2) && int.TryParse(n3, out num3)) {
            //Math.Max nao aceita mais de 2 argumentos!
            int res = Math.Max(Math.Max(num1, num2), num3);

            Console.WriteLine("O maior valor e o {0}", res);
        } else {
            Console.WriteLine("Valor ivalido!");
        }
    }
}