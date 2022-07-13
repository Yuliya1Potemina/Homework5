/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
   arr[i] = randomizer.Next(1, 12);
}

return arr;
}

void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}

int GetPositiveSumm(int[] arr)
{
int result = 0;

for (int i = 0; i < arr.Length; i=i+2)
{
        result = result + arr[i];
        
}

return result;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int [] array = GetArray(dimension);
PrintArray(array);
int OddSumm = GetPositiveSumm(array);


Console.WriteLine($"Сумма эллементов стоящих на нечётных позициях {OddSumm}");