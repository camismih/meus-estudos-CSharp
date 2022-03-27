        using System;
class Program
{
            static void Main (string [] args)
    {
        Console.WriteLine("Sequência de Fibonacci");
                        int n1 = 0;             
        int n2 = 1;
        int fib = 0;
        while( fib <=100)
        {
            Console.WriteLine( $" {fib} {n2} ");
            int aux =n2;
            n2 =n2 +n1;
            n1 = aux;            
            }
            fib ++;
            
            Console.ReadLine();
            }
}    
            