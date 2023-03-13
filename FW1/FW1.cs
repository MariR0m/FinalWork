// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// | ["1234", "1567", "-2", "сотршег вс1епсе"] -> ["-2"]
// ["Впзы1а", "ОептагК", "Кагап"] -> []


string[] ArrayFilling (string[] Array)
{
for (int i=0; i<Array.Length; i++)
{
    System.Console.WriteLine("Введите элемент: ", i);
    Array[i] = Console.ReadLine();
}
return Array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

string[] ElementSearch (string[] Array, int count)
{
string[] Array2 = new string[count];
 int j=0;
 for (int i=0; i<Array.Length; i++)
 {
if (Array[i].Length<4)
{
Array2[j] = Array[i];
 j++;
}
 }
 
 return Array2.Take(j).ToArray();
}

int count;

System.Console.WriteLine("Количество элементов: ");
count = Int32.Parse(Console.ReadLine());

string[] Array = new string[count];
ArrayFilling (Array);
System.Console.WriteLine();
System.Console.WriteLine("Полученный массив: ");
PrintArray(Array);
System.Console.WriteLine();
System.Console.WriteLine("Элементы массива длинна которых меньше либо равна 3 символа: ");
PrintArray(ElementSearch(Array, count));
