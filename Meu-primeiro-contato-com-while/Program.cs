using System;
class program   
{
    static void Main (string [] args)
    {
        Console.WriteLine("executando o projeto 10 - cálculo poupança.");
double valorinvestido = 1000;
int contadormes = 1;
while(contadormes<=12)
{
    valorinvestido = valorinvestido+valorinvestido*0.0036;
Console.WriteLine($"Após {contadormes}MesesVocê terá  R$ {valorinvestido} ");
contadormes++;          
}
Console.ReadLine();
}
}