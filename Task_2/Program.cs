// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.
Console.Write("Введите b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());
double x=0;
double y=0;
double y1=0; // Для проверки решения
if (k2==k1)
{
    Console.WriteLine("Отрезки не пересекаются");
}
else if (b1-b2 == 0)
{
    Console.WriteLine($"Точки пересечения прямых равны (0;{b1})");
}
else 
{
// Путем простых математических действий пишем уравнение для нахождения x: 
//y=y => k1*x+b1 = k2*x+b2 => k1*x-k2*x=b2-b1 => x*(k1-k2)=b2-b1 => x=(b2-b1)/(k1-k2);
//b1=2, k1=5, b2=4, k2=9 =>(-0,5;5,5) Если х=-0,5 мы подставляем х в выражение y=k2*x+b2 => y = 9*(-0,5)+4 => y=-4,5+4 => y=-0,5
// y=k1*x+b1 => y=5*(-0,5)+2 => y=-2,5+2 => y=-0,5. Не могу понять как получилось у=5,5?
x= (b1-b2)/(k2-k1);
y = k2*x+b2;
y1=k1*x+b1;
if (Math.Round(y,2)==Math.Round(y1,2))
{
Console.WriteLine($"Координаты пересечения прямых равны ({Math.Round(x,2)};{Math.Round(y,2)})");
}
else
{
   Console.WriteLine ("Проверьте свое решение");
}
}