using System;

class Program { 
    static void Main() {
        init:
        Console.WriteLine("Digite um numero inteiro: ");
      //  int res = Convert.ToInt32(Console.ReadLine());
      string num = Console.ReadLine();
      int n1;

      if (int.TryParse(num, out n1)) {
        
        if(n1 % 2 == 0) {
            Console.WriteLine("E par!");
        } else {
            Console.WriteLine("E impar!");
        }
      } else {
        Console.WriteLine("Valor incorreto! ");
        goto init;
      }
    }
}