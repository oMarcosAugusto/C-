// using System;

// class Program {
//     static void Main() {
//         Console.WriteLine("Digite a letra F ou M");
//         string res = Console.ReadLine();

//         if (res.Equals("F", StringComparison.OrdinalIgnoreCase)) {
//             Console.WriteLine("Você digitou 'F'");
//         } else if (res.Equals("M", StringComparison.OrdinalIgnoreCase)) {
//             Console.WriteLine("Você digitou 'M'");
//         } else {
//             Console.WriteLine("Opção inválida.");
//         }
//     }
// }


using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite a letra F ou M");
        string res = Console.ReadLine();

        if (res.ToUpper() == "F") {
            Console.WriteLine("Você digitou 'F' ou 'f'.");
        } else if (res.ToUpper() == "M") {
            Console.WriteLine("Você digitou 'M' ou 'm'.");
        } else {
            Console.WriteLine("Opção inválida.");
        }
    }
}

