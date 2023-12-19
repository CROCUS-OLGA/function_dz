
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(99, 1000);
// }
// // функция возвращает True если число простое, иначе False
// bool CheckChetnoe(int x)
// {
//     if (x % 2 == 0)
//         return true;
//     else    
//         return false;
// }
// void ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (CheckChetnoe(array[i]))
//             count ++;
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);
//------------------------------------------------------------------
// Задача 1: Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// int CountSumma(string input)
// {
//     int sum = 0;
//     for (int i = 0; i < input.Length; i++)
//     {
//         sum = sum + Convert.ToInt32(input[i].ToString());
//     }
//     return sum;
// }

// bool isChetnoe(int sum)
// {
//     if (sum % 2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Clear();
// while (true)
// {
//     Console.Write("Введите число:");
//     var input = Convert.ToString(Console.ReadLine());
//     if (input == "q")
//     {
//         Console.WriteLine("[STOP]");
//         break;
//     }
//     else
//     {
//         var sum = CountSumma(input);
//         if (isChetnoe(sum))
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//         else
//         {
//             Console.WriteLine(sum);
//         }
//     }
// }
//---------------------------------------------------------

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100);
// }
// void ReleaseArray(int[] array, int[] arr)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         arr[i] = array[array.Length - 1 - i];
//     }
//     Console.WriteLine(string.Join(", ", arr));
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// int[] arr = new int[n];
// ReleaseArray(array, arr);
//--------------------------------------------------------