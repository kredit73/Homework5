//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
public class MyLibrary
{
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }
    /// <summary>
    /// Этот метод заполняет массив случайными числами.
    /// </summary>
    /// <param name="array">пустой массив.</param>
    /// <param name="arg1">минимальное значение.</param>
    /// <param name="arg2">максимальное значение.</param>

    public static void Fill(int[] array, int arg1, int arg2)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(arg1, arg2);
        }
    }

    /// <summary>
    /// Метод записи массива в переменную типа string.
    /// </summary>
    /// <param name="array">Тот массив, который мы должны использовать.</param>
    /// <returns>Возвращает массив заполненный в переменную типа string.</returns>
    public static string Print(int[] array)
    {

        string result = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i]}, ";
        }
        return result;
    }

    /// <summary>
    /// Метод возвращает количество четных чисел в заданном массиве.
    /// </summary>
    /// <param name="array">Сюда вводим название массива в котором хотим узнать количество четных чисел.</param>
    /// <returns>возвращает количество четных.</returns>

    public static int countEven(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        return count;
    }

    /// <summary>
    /// Метод ищет сумму элементов в массиве, стоящих на нечетных позициях.
    /// </summary>
    /// <param name="array">Массив, в которм нужно найти</param>
    /// <returns>вщзврат суммы</returns>
    public static int sumEven(int[] array)
    {

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {

            if (i % 2 == 0)
            {
                count = count + array[i];
            }
        }
        return count;
    }
    public static double[] CreateArrayDouble(int count)
    {
        return new double[count];
    }
    /// <summary>
    /// Этот метод заполняет массив случайными числами.
    /// </summary>
    /// <param name="array">пустой массив.</param>
    /// <param name="arg1">минимальное значение.</param>
    /// <param name="arg2">максимальное значение.</param>

    public static void FillDouble(double[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() + rnd.Next(1, 100);
        }
    }

    /// <summary>
    /// Метод записи массива в переменную типа string.
    /// </summary>
    /// <param name="array">Тот массив, который мы должны использовать.</param>
    /// <returns>Возвращает массив заполненный в переменную типа string.</returns>
    public static string PrintDouble(double[] array)
    {

        string result = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i]:0.00}  ";
        }
        return result;
    }

    /// <summary>
    /// Находит разность в массиве между самым большим и самым маленьким эоементом массива
    /// </summary>
    /// <param name="array">Наименование массива</param>
    /// <returns>возвращает разность</returns>


    public static double diffDoubleArray(double[] array)
    {
        double max = array[1];
        double min = array[1];
        double diff = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > max) max = array[i];
            if(array[i]<min) min = array[i];

        }
        //for (int i = 0; i < array.Length; i++)
        //{
          //  if(array[i]<min) min = array[i];
       // }
        diff = max - min;

        return diff;
    }

































}
