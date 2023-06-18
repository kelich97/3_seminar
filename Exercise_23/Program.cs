/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

void Cube(int number)
{
    int current = 1;
    while(current <= number)
    {
        double loky = Math.Pow(current, 3);
        Console.Write($"{loky : 0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.WriteLine("number");
int user_n = Convert.ToInt32(Console.ReadLine());
Cube(user_n);
