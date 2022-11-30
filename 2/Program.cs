/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */
int count = 0;
int numbers;
Console.WriteLine("Укажите сколько ввести чисел: ");
numbers = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[numbers];
for (int i = 0; i < numbers; i++)
{
Console.WriteLine("Введите {0}-й элемент", i + 1);
mas[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numbers; i++)
{
if (mas[i] > 0)
{
count++;
}
}

Console.WriteLine();
Console.WriteLine("Количество чисел больше нуля = " + count);