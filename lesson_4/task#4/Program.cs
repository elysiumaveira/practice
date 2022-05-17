using System;
 
// класс двумерного массива
class Array2
{
    private int[,] _arr;       // внутренний массив для хранения значений
    
    public Array2( int dim1, int dim2 )
    {
        _arr = new int[dim1,dim2];  // создание внутреннего массива            
    }
    
    public Array2( Array2 other )
    {
        _arr = other._arr;
    }
    
    public int GetLength( int d )
    {
        return _arr.GetLength( d );        
    }

    public int GetValue( int i1, int i2 )
    {
        return _arr[i1, i2];
    }
    
    public void SetValue( int i1, int i2, int val )
    {
        _arr[i1, i2] = val;
    }
    
    // перегруженный оператор 'меньше'
    public static bool operator< ( Array2 a1, Array2 a2 )
    {
        int min1 = Math.Min( a1.GetLength( 0 ), a1.GetLength( 1 ) );
        int sum1 = 0;
        for( int i1 = 0; i1 < min1; i1++ )
            sum1 += a1.GetValue( i1, i1 );
 
        int min2 = Math.Min( a2.GetLength( 0 ), a2.GetLength( 1 ) );
        int sum2 = 0;
        for( int i2 = 0; i2 < min2; i2++ )
            sum2 += a2.GetValue( i2, i2 );
        
        return sum1 < sum2;
    }
 
    // перегруженный оператор 'больше'
    public static bool operator> ( Array2 a1, Array2 a2 )
    {
        int min1 = Math.Min( a1.GetLength( 0 ), a1.GetLength( 1 ) );
        int sum1 = 0;
        for( int i1 = 0; i1 < min1; i1++ )
            sum1 += a1.GetValue( i1, i1 );
 
        int min2 = Math.Min( a2.GetLength( 0 ), a2.GetLength( 1 ) );
        int sum2 = 0;
        for( int i2 = 0; i2 < min2; i2++ )
            sum2 += a2.GetValue( i2, i2 );
        
        return sum1 > sum2;
    }
}
 
class Program
{
    public static void Main()
    {
        // длины массивов
        int
            len11 = 3,
            len12 = 4,
            len21 = 5,
            len22 = 3;
 
        
        Console.Write($"Создаём двумерный массив [{len11},{len12}]...") ;
        Array2 a21 = new Array2( len11, len12 );
        
        Console.Write($"\nСоздаём двумерный массив [{len21},{len22}]...");
        Array2 a22 = new Array2( len21, len22 );
        Console.WriteLine( "\n" );

        int min = -10, max = 10;
        Random r = new Random();

        Console.WriteLine($"Заполняем массив 1 случайными числами из отрезка [{min},{max}]");
        for( int i = 0; i < a21.GetLength(0); i++ )
        {
            for( int j = 0; j < a21.GetLength(1); j++ )
            {
                a21.SetValue( i, j, r.Next( min, max ) );
                Console.Write($"{a21.GetValue( i, j )} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Заполняем массив 2 случайными числами из отрезка [{min},{max}]");
        for( int i = 0; i < a22.GetLength(0); i++ )
        {
            for( int j = 0; j < a22.GetLength(1); j++ )
            {
                a22.SetValue( i, j, r.Next( min, max ) );
                Console.Write($"{a22.GetValue( i, j )}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine( "Сравниваем массивы:" );
        Console.WriteLine($"Массив 1 меньше массива 2: {a21 < a22}");
        Console.WriteLine($"Массив 1 больше массива 2: {a21 > a22}");
    }
}