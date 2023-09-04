using System.Dynamic;
using System.Globalization;

Console.WriteLine("введите число");
int CountElements = Convert.ToInt32(Console.ReadLine());
int[] number = new int [CountElements];
int count = 0;
Random rand = new Random();
Console.WriteLine("заполнение массива случайными числами");
for(int i = 0; i < number.Length;i++)
{
    number[i] = rand.Next(100);
    Console.WriteLine($"{number[i]}");
}
Console.WriteLine();
for(int i = 0; i < number.Length;i++)
{
if(i % 2!= 0);
count += number[i];
}
Console.WriteLine(count);