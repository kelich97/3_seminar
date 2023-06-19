/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double dist = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
    dist = Math.Round(dist, 2);
    return dist;
}
Console.WriteLine("Input X coord of A");
int xcoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coord of B");
int xcoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of A");
int ycoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of B");
int ycoordB = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input Z coord of A");
int zcoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coord of B");
int zcoordB = Convert.ToInt32(Console.ReadLine());
double distance = Distance(xcoordA, xcoordB, ycoordA, ycoordB, zcoordA, zcoordB);
Console.WriteLine(distance);