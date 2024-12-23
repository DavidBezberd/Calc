using System;

public class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введіть перше число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Введіть дію (+, -, *, /): "); 
            char operation = char.Parse(Console.ReadLine().Trim());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: ділення на нуль");
                    }
                    break;
                default:
                    Console.WriteLine("Неправильна операція");
                    break;
            }
        }
    }
}
