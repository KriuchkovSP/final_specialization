// Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

string[] FillArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива ({i + 1} из {size}): ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] GetArrWithElemLess3 (string[] array)
{
    int j = 0;
    string[] temp = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            temp[j] = array[i];
            j++;
        }
    }
    string[] result = new string[j];
    for (int i = 0; i < j; i++)
    {
        result[i] = temp[i];
    }
    return result;
}

void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"\"{array[i]}\", ");
        else Console.WriteLine ($"\"{array[i]}\"]");
    }
    if (array.Length == 0) Console.WriteLine ("[]");
}


Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ());

string[] arr = FillArray(insize);
string[] resultArray = GetArrWithElemLess3(arr);
Console.WriteLine ("Введеный массив:");
PrintArr(arr);
Console.WriteLine ("Результат:");
PrintArr(resultArray);