using System;

public class Example
{ 
   public static void Main()
    {
        Console.WriteLine("Input your number:");
       
        int nr = 0;
      
        switch (nr)

       { 
            case 0:
            Console.ReadLine();
            if (nr == 0)
            Console.WriteLine("Correct");
            Environment.Exit(0);
            break;
             
           default:
           Console.ReadLine();
           if (nr != 0)
           Console.WriteLine("Invalid input!");
           Environment.Exit(0);
           break;
        }
    }

}
    


