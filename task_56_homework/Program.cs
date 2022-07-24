// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой 
//элементов.
int[,] massive = new int[4, 3];
int[] sum = new int[massive.GetLength(0)];
for (int i = 0; i < massive.GetLength(0); i++)
{
      for (int j = 0; j < massive.GetLength(1); j++)
      {
            massive[i, j] = new Random().Next(1, 10);
            Console.Write(massive[i, j] + " ");
      }
      Console.WriteLine();
}
Console.WriteLine();// задаем произвольный массив
for (int i = 0; i < massive.GetLength(0); i++)// находим сумму строки
{
      for (int j = 0; j < massive.GetLength(1); j++)
      {
            sum[i] = sum[i] + massive[i, j];
            Console.Write(sum[i]+" ");
      }
      Console.WriteLine();
}

int Min(int[] array) // сравниваем суммы строк
        {
            int Min = array[0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    if (Min > array[i])
                    {
                        Min = array[i];
                    }
            }
            Console.WriteLine($"Строка с суммой {Min} является наименьшей строкой");
            return Min;
        }
Min(sum);

