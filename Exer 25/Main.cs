using System;

class Program {
    static void Main() {   
        Console.WriteLine("Digite dois numeros: ");
        int n1 = Convert.ToInt32(Console.ReadLine()); 
        int n2 = Convert.ToInt32(Console.ReadLine());   

       for (int i = n1+1; i < n2; i++)
       {
            Console.WriteLine(i);
       }
    }
}