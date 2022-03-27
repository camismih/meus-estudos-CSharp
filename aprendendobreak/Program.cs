Console.WriteLine("Aprendendo Break");
for    (int contadorlinha =0; contadorlinha <10; contadorlinha ++)
{
    for( int contadorcoluna =0; contadorcoluna<10; contadorcoluna ++)
    {
        Console.Write("*");
        if( contadorcoluna>= contadorlinha)
        break;
    }
    Console.WriteLine();

}
Console.ReadLine(); 