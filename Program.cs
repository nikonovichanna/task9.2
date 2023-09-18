/*Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(SumMN(m , n));

int SumMN(int m, int n) 
{
    int sum = (m + n) * (n - m + 1) / 2;
    return sum; 
}*/


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(SumMN(m , n ));

int SumMN(int m, int n) 
{
    if (m == n)
    return n;
    else
    return m + SumMN(m + 1, n);   
}