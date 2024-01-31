using System;

class Program {
    static void Main() {   
        
        Console.WriteLine("Digite o numero da tabuada desejada: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0 ; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + n * i);            
        }
    }
}
