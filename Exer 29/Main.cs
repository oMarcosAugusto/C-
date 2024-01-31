using System;

class Program {
    static void Main() {   
        
       int[] array = new int[50];

       for (int i = 0; i < 50; i++)
       {
            array[i] = i + 1;
       }      
       Console.WriteLine(array[23]);
    }
}