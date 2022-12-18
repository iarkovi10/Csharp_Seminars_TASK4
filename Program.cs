//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите первое число");
//string numberStr = Console.ReadLine() ??"";
int number = int.Parse(Console.ReadLine()??"0");
if (number < 0)
{
    Console.WriteLine("Неверный код");
}
else
{
    int count = 1;
    while (count < number)
    {
        count ++;
        if (count%2 == 0)
        {
            Console.WriteLine($"{count}");
        }
    }
} 



