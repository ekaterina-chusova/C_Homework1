/*Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();

Console.Write("Введите целое число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (num > 1)
{
    while (count <= num)
    {
        if (count >= num - 1)
        {
            Console.Write(count + ". ");
        }
        else 
        {
            Console.Write(count + ", ");
        }    
        count = count + 2;
    }
}
else Console.Write("Ошибка ввода. Введите целое число больше 1");