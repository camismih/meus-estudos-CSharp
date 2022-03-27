using System;
class program
{
    static void Main (string [] args)
    {
        Console.WriteLine("escopo");
        int idadejoao = 18;
        bool acompanhado = true;
        string mensagemadicional;
        if(acompanhado == true)
        {
            mensagemadicional ="joão está acompanhado !";
        }
        else
    {
        mensagemadicional = "João não está acompanhado";
    }
    if(idadejoao >= 18 && acompanhado == true   )
    {
        Console.WriteLine("Pode entrar");
        Console.WriteLine(mensagemadicional);
            }
            else
            {
            Console.WriteLine("não pode entrar");
            }
            Console.ReadLine();
    }
}