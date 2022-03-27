using System;
class program
{
    static void Main (string[] args) 
    {
Console.WriteLine("Aprendendo fluxo de controle e estrutura de decisão");
int idadejoão =16;
int quantidadedepessoas =2;
if(idadejoão>= 18)
{
Console.WriteLine("João  é maior de 18 anos. Pode entrar.");
}
else
{
    if(quantidadedepessoas>=2)
        {
        Console.WriteLine("João é menor, mas está acompanhado por sua mamacita. Pode entrar este desgraçado.");
    }

else
{
    Console.WriteLine("joão é menor, não pode entrar. volta pra casa e vai mamar na teta da mamãe.");
}
}
    Console.ReadLine();
    }
}
