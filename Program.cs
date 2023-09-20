class Calculator
{
    static void Main()
    {
        int choice = 0;
        double num1 = 0, num2 = 0, result = 0;

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. 1 процент от числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выйти из программы");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}\n");
                    break;

                case 2:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}\n");
                    break;

                case 3:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}\n");
                    break;

                case 4:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка! Деление на ноль невозможно.\n");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}\n");
                    }
                    break;

                case 5:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine($"{num1} ^ {num2} = {result}\n");
                    break;

                case 6:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Квадратный корень из {num1} = {result}\n");
                    break;

                case 7:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / 100;
                    Console.WriteLine($"1% от {num1} = {result}\n");
                    break;

                case 8:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Factorial(num1);
                    Console.WriteLine($"Факториал {num1} = {result}\n");
                    break;

                case 9:
                    Console.WriteLine("До свидания!");
                    break;

                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.\n");
                    break;
            }

        } while (choice != 9);
    }

    static double Factorial(double num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}