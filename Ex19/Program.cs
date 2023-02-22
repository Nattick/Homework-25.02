// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Number ()
{
    Console.WriteLine("Enter a 5-digit number and find out if it's palindrome");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}
bool range(int N)
{
    if (N > 9999 && N < 100000) return true;
    else return false;
}
void Palindrome(int N)
{
    if (range(N))
{
    if(N/10000 == N % 10 && (N/1000) % 10 == (N % 100)/10)
    {
        Console.WriteLine("Hooray! We have a palindrome here!");
    }
    else Console.WriteLine("Sorry, not a palindrome...");
}
else Console.WriteLine("This is not a 5-digit number. Think again!");
}