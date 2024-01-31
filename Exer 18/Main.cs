using System;

class Program {
    static void Main() {
        init:
        Console.WriteLine("Digite 2 números: ");
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();

        int num;
        int num2;

        if (int.TryParse(n1, out num) && int.TryParse(n2, out num2)) {
            operation:
            Console.WriteLine("Escolha a operação desejada (+ | - | * | /)");
            string op = Console.ReadLine();

            switch (op) { 
                case "-":
                    Console.WriteLine(num - num2);
                    break;
                case "+":
                    Console.WriteLine(num + num2);
                    break;
                case "*":
                    Console.WriteLine(num * num2);
                    break;
                case "/":
                    Console.WriteLine(num / num2);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    goto operation;
            }
        }
        else {
            Console.WriteLine("Os números inseridos não são válidos.");
            goto init;
        }
    }
}
