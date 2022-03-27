using System;
class Program
{
   static void Main(string [] args){
      Console.WriteLine("Trabalhando com vários tipos de variáveis para números inteiros e flutuantes, aAprendendo cassting.");
   double salario = 1200.50;
   int salario_inteiro = (int ) salario;
   Console.WriteLine("O seu salário é" +salario_inteiro +"." );
 short valor_compra =(int) 150;
   int saldo = salario_inteiro - valor_compra;
         Console.WriteLine("Você gastou mais do que pode este mês. e não vai conseguir pagar o aluguel, seu besta. Você tem o saldo de" +saldo +".");
float altura =1.80f;
long idade_universo =13000000;
Console.WriteLine("Sua altura é"+altura +"." +"Porém, sua burrisse é do tamanho daidade do universo." +idade_universo +".");
Console.ReadLine();     
   }
}