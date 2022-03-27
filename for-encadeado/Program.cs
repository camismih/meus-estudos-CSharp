using System;
class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Treinando encadeamento.");
        double valorinvestido = 1000;
double fatorderendimento = 1.0036;
        for( int contadorano =1; contadorano <=5; contadorano++)
        {
            for( int contadormes =1; contadormes <=12; contadormes ++)
            {
valorinvestido*= fatorderendimento;
            }
fatorderendimento += 0.0010;
        }
        Console.WriteLine($"Ao término do investimento, você terá R$ {valorinvestido} ");
        Console.ReadLine();

            }
}