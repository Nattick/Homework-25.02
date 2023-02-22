// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Dots (int[] X)
{
    Console.WriteLine("Enter x, y, z: ");
    Console.Write("x =" + " ");
    X[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("y =" + " ");
    X[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("z =" + " ");
    X[2] = Convert.ToInt32(Console.ReadLine());
}

double Lon(
    int[] A,
    int[] B)
{
double lon = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2));
return lon;
}

int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Enter first point coordinates.");
Dots(A);
Console.WriteLine("Enter second point coordinates.");
Dots(B);

Console.WriteLine($"Distance between points: {Lon(A, B)}");