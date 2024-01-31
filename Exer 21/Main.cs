using System;

class Program {
    static void Main() {
        Console.WriteLine("Que horas são?: ");
        int horaAtual = Convert.ToInt32(Console.ReadLine());

        // DateTime agora = DateTime.Now;
        // int horaAtual = agora.Hour;

        if (horaAtual >= 6 && horaAtual < 12) {
            Console.WriteLine("Bom dia!");
        } else if (horaAtual >= 12 && horaAtual < 18) {
            Console.WriteLine("Boa tarde!");
        } else if (horaAtual >= 18 && horaAtual <= 23) {
            Console.WriteLine("Boa noite!");
        } else {
            Console.WriteLine("Erro: Fora do intervalo válido para o dia.");
        }
    }
}
