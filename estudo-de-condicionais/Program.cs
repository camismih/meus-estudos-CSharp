using System;

    namespace transação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu primeiro desafio de condicionais!");
            decimal saldoatual = 00.01M;
            decimal chequeespecial =8000M;
            bool contapopanca = false;      
0        decimal valoroperacao = 1600.00M;
        if(valoroperacao <= saldoatual)
        {
            Console.WriteLine($"Operação realizada com sucesso! seu saldo atual é{valoroperacao-saldoatual}");
            }
            else{
             if(contapopanca||chequeespecial<valoroperacao)   
             {
Console.WriteLine("Você não tem saldo suficiente e não pode realizar esta operação");
             }
             else{
                 Console.WriteLine($"Você ainda tem {saldoatual+chequeespecial-valoroperacao} de cheque especial");
             }
             Console.ReadLine();
            }
        }
    }
}

