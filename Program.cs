// Показать натуральные числа от N до 1, N задано.
// N = 5. -> "5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Задайте N: ");
int num = int.Parse(Console.ReadLine());

void show(int n)
{
    if (n > 0)
    {
        Console.Write(n + "   ");
        show(n - 1);        
    }
}
show(num);