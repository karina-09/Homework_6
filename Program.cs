Console.Clear();


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго 
// больше 0 ввёл пользователь.   0, 7, 8, -2, -2 -> 2       1, -7, 567, 89, 223-> 4


/*Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int result = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
Console.WriteLine($"Кол-во элементов больше 0: {result}");*/
 
 
// Задача 43: Написать программу, которая на вход принимает массив из любого 
// количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит 
// этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

/*int[] Array = GetArray (6, 0, 100);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine($"[{String.Join(",", Sort(Array))}]");


int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int[] Sort (int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }                   
        }            
    }
        return array;
}*/

