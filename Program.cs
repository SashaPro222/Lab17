
// int[] scores = { 60, 80, 40, 80, 90 };
// int sum = 0;
// foreach (int score in scores)
// {
//     sum += score;
// }
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(scores));
// int sum = 0;
// int SumArray(int[] numbers)
// {
//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));
// int count = 0;
// count++;
// int CountAtLeast(int[] numbers, int limit)

// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountAtLeast(scores, 50));
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count ++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));
// int FindMax(int[] numbers)
// {
//     int max = numbers[0];
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//     }
//     return max;
// }
// int FindMin(int[] numbers)
// {
//     int min = numbers[0];
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }
//     }
//     return min;
// }
// System.Console.WriteLine("Минимум:", FindMin(scores));
// System.Console.WriteLine("Максимум:",FindMax(scores));
// Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));
// int FindIndex(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }
//     return -1;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 100));
// int FindIndex(int[] numbers, int target)
// {
//     int index = -1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 60));
// Console.WriteLine(FindIndex(scores, 100));

int[] scores = new int[7];

for (int i = 0; i < scores.Length; i++)
{
 Console.Write($"Результат {i + 1}: ");
 scores[i] = Convert.ToInt32(Console.ReadLine());
}
int SumArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}
int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
int FindMin(int[] numbers)
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
int CountAtLeast(int[] numbers, int limit)

{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine(">>> Анализ результатов <<<");
System.Console.WriteLine("");
System.Console.WriteLine("Сумма:", SumArray(scores));
System.Console.WriteLine("Минимум:", FindMin(scores));
System.Console.WriteLine("Максимум:", FindMax(scores));
System.Console.WriteLine("Результатов 50 и больше:", CountAtLeast(scores, 50));
System.Console.WriteLine("Какой результат найти:");
int target = int.Parse(Console.ReadLine());
int ind = 0;
int FindIndex(int[] numbers, int target)
{
    int index = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            index = i;
            break;
        }
    }
    if (index != -1)
    {
        System.Console.WriteLine("Первый индекс:", index);
    }
    else
    {
        System.Console.WriteLine("Результат не найден");
    }
}

FindIndex(scores, target);


