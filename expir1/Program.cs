// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};


Console.WriteLine("Введите кол-во элементов начального массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string? [] array = new string[size];
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Console.ReadLine();
    if(array[i]!.Length <= 3)
    {
        n++;
    }
 }

if (n == 0 )
{
    Console.WriteLine("Строк нужной размерности не найдено. Повторите процедуру!");
    return;
}
else
{
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
}

string? [] arrayRes = new string[n];
int k = 0;
for (int j = 0; j < size; j++)
{
    if(array[j]!.Length <= 3)
    {
        arrayRes[k] = array[j];
        k++;
        
    }
}
Console.WriteLine("Результирующий массив: [" + string.Join(", ", arrayRes) + "]");