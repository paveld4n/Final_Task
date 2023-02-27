// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
// Вариант итогового задания с использованием метода


Console.WriteLine("Введите кол-во элементов начального массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedN)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}

string[] array = CreateFirstArray(n);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
int size = GetSizeEndArray(array);
if (size == 0)
{
    Console.WriteLine($"Строк нужной размерности не найдено. Повторите процедуру!");
    return;
}
else
{
    Console.WriteLine($"Количество трех и менее значных элементов = {size}");
}

string [] arrayRes = CreateEndArray(array, size);
Console.WriteLine("Результирующий массив: [" + string.Join(", ", arrayRes) + "]");


string[] CreateEndArray(string [] arrayFirst, int sizeAra)
{
    string [] arrayRes = new string[sizeAra];
    int k = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if(arrayFirst[i]!.Length <= 3)
        {
            arrayRes[k] = arrayFirst[i];
            k++;
        }
    }
    return arrayRes;
}


string [] CreateFirstArray(int m)
{
    string [] array = new string[m];
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write("Введите значения массива: ");
        array[i] = Console.ReadLine()!; 
    }
    return array;
}

int GetSizeEndArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]!.Length <= 3)
        {
            count++;
        }
        
    }

    return count;  
}

