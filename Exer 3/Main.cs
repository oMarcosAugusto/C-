using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite suas 4 notas bimestrais: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int n4 = Convert.ToInt32(Console.ReadLine());

        int res = (n1 + n2 + n3 + n4) / 4;
        
       Console.WriteLine("A media e: " + res);
    }
} 