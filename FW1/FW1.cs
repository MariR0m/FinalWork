// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// | ["1234", "1567", "-2", "сотршег вс1епсе"] -> ["-2"]
// ["Впзы1а", "ОептагК", "Кагап"] -> []


string[] ArrayFilling(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine("Введите элемент: ", i);
        Array[i] = Console.ReadLine();
    }
    return Array;
}

void PrintArray(string[] Array)
{
    System.Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

string[] ElementSearch(string[] Array, int Count)
{
    string[] NewArray = new string[Count];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length < 4)
        {
            NewArray[j] = Array[i];
            j++;
        }
    }

    return NewArray.Take(j).ToArray();
}

int Count;

System.Console.WriteLine("Введите количество элементов: ");
Count = Int32.Parse(Console.ReadLine());

string[] Array = new string[Count];

ArrayFilling(Array);
System.Console.WriteLine();

System.Console.WriteLine("Полученный массив: ");
PrintArray(Array);
System.Console.WriteLine();

System.Console.WriteLine("Элементы массива длинна которых меньше либо равна 3 символа: ");
PrintArray(ElementSearch(Array, Count));
