using System;

class Program {
    static void Main() {   
        
       int[] nums = {1,2,3,4,5,6,7,8,9,10};
       Array.Reverse(nums);       

       foreach (var num in nums)
       {
            Console.WriteLine(num);
       }       
    }
}