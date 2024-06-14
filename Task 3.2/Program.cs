using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
            {
                int product = number1 * number2;
                Console.WriteLine($"Произведение: {product}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа от 0 до 10.");
            }
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
