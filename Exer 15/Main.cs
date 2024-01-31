using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite duas notas: ");
        string i1 = Console.ReadLine();
        string i2 = Console.ReadLine();

        int n1, n2;

        if (int.TryParse(i1, out n1) && int.TryParse(i2, out n2)) {
            int res = n1 + n2;

            if (res == 10) {
                Console.WriteLine("Aprovado com Distinção!");
            } else if (res >= 7) {
                Console.WriteLine("Aprovado!");
            } else {
                Console.WriteLine("Reprovado!");
            }
        } else {
            Console.WriteLine("Por favor, digite o número de sua nota!");
        }
    }
}
