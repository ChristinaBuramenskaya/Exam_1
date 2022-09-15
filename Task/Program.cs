Console.WriteLine("Введите элементы массива через запятую");
string element = Console.ReadLine();
string[] array = element.Split(',');
int max_symbols = 3;
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1)
    {
        if (array[i].Length <= max_symbols)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    else if (array[i].Length <= max_symbols)
    {
        Console.Write($"{array[i]}");
    }
}
Console.Write("]");
