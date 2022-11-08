// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] GetArray(string array)
{
    string[] num = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[num.Length];

    for (int i = 0; i < num.Length; i++)
    {
        res[i] = int.Parse(num[i]);
    }
    return res; 
}

int CountPositive(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > 0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа: ");
string input = Console.ReadLine()!;
int[] numArr = GetArray(input);
int count = CountPositive(numArr);
Console.WriteLine($"Количество чисел больше 0: {count}");