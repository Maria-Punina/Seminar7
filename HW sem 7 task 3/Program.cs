// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. 

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] array = { 1, 2, 5, 0, 10, 34 };
int num = array.Length - 1;
int ArrayNumsRevers(int num,int[] array)
{
    if (num < 0)
    {        
        return 0;
    }
    Console.Write($" {array[num]} ");
    return  ArrayNumsRevers(num - 1 , array);
}
Console.WriteLine($"Исходный массив: [ {array[0]}  {array[1]}  {array[2]}  {array[3]}  {array[4]}  {array[5]} ]");
Console.Write("Массив с конца: [");
ArrayNumsRevers(num, array);
Console.Write("]");



