// принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите два числа");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if (n / m == m)
{
    Console.WriteLine("является квадратом");
}
    else
    
        if (m / n == n)
        {
            Console.WriteLine("является квадратом");
        }
    
else
    Console.WriteLine("не является квадратом");

