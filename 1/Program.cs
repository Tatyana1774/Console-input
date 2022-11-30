    /*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 4 */
    void CountPosetiveNumber(int number)
    {
    int count = 0;
    for (int i = 0; i < number; i++)
    {
    Console.Write("Введите число: ");
    int container = Convert.ToInt32(Console.ReadLine());
    if (container > 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше нуля равно {count}");
    }
    Console.Write("Введите колличество чисел которые будете сравнивать: ");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    CountPosetiveNumber(input);

