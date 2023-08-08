// See https://aka.ms/new-console-template for more information
Console.Write("Enter number: ");
int a = 0;
a = Convert.ToInt32(Console.ReadLine());
if ( a > 0 )
{
    int b = 0;
    while ( b < a )
    {
        Console.WriteLine( b % 2 == 0 ? $"Juft {b}" : "" );
        Console.WriteLine( b % 2 == 1 ? $"Toq  {b}" : "" );
        b ++;    
        
    }
}

