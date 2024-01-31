using System;

class Program { 
    static void Main() {
        Console.WriteLine("Qual o tamanho do arquivo em MB a ser baixado?: ");
        double tamanhoEmMb = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual e a velocida do seu link de internet em Mbps?: ");
        double velMbps = Convert.ToDouble(Console.ReadLine());
        
        double tamanhoMb = tamanhoEmMb * 8;
        double tempoDownload = tamanhoMb / velMbps;

        Console.WriteLine("Ira demorar em media: " + tempoDownload + " segundos para baixar esse arquivo!");
    }
}