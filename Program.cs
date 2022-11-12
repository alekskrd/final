/* Написать программу которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 
3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
при решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. 
Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"] */


Console.Clear();
Console.WriteLine();
string[] arr = new string[] {"hello", "7", "777", "world", ":-)"};
const int symbol = 4;   //вывод строк меньше либо равно 3 символ


int size = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < symbol) size++;
}
string[] array = new string[size];
int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < symbol)
    {
        array[j] = arr[i];
        j++;
    }
}
PrintArray(arr);
Console.WriteLine(">>>");
PrintArray(array);



void PrintArray(string[] argument)
{
    Console.WriteLine("[" + String.Join("; ", argument) + "]");
}