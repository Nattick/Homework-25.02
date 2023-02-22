// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N();
{
    Console.WriteLine("Enter any number:");
    int n = Convert.ToInt32(Console.Readline());
    return n;
}
void Cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int cube i * i * i;
        Console.Write($"cube ");
    }
}
int n  = N();
Console.Writeline($"1 to {n} cube:  ");
Cube(n);