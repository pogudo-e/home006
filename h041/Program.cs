// int age = Convert.ToInt32(Console.ReadLine());
int m;
Console.Write("Введите число элементов массива: ");
m = Convert.ToInt16(Console.ReadLine());
int [] array = new int[m];
int i = 0;
while (i < m)
{
    Console.Write("Введите элемент массива: ");
    array[i] = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    i++;
}

void AboveZero (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0){
            result++;
        }
    }
    Console.WriteLine($"Я насчитал: {result} положительных числа.");
}

AboveZero(array);