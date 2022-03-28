// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//1 вариант решения
// Console.Write("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for(int i=0; i<M;i++)
// {
//     Console.Write($"Введите {i+1} число: ");
//     int B = Convert.ToInt32(Console.ReadLine());
//     if (B>0)
//     {
//         count++;
//     }
// }
// Console.Write($"Количество чисел больше 0 равно {count}");

//2 вариант решения
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    // Console.Write($"Введите {i + 1} число: "); //Ручной ввод чисел строки 24,25,26
    // int B = Convert.ToInt32(Console.ReadLine());
    // array[i] = B;
    array[i] = new Random().Next(-100,101); // Рандом чисел
    if (array[i] > 0)
    {
        count++;
    }
}
//Console.Write("Вы ввели числа: "); Для ручного ввода чисел
Console.Write("Рандомно сгенерированные числа: "); //Для рандома
Console.WriteLine(string.Join(", ", array));
Console.Write($"Количество чисел больше 0 равно {count}");