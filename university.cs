using System;

public class OneDimensionalArray
{
    private int[] array;
    private int length;

    public OneDimensionalArray(int size)
    {
        length = size;
        array = new int[size];
    }

    public int Length
    {
        get { return length; }
    }

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < length)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            }
        }
        set
        {
            if (index >= 0 && index < length)
            {
                array[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            }
        }
    }

    public void ReplaceNegativesWithAbs()
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Abs(array[i]);
            }
        }
    }

    public void FillWithRandomNumbers(int minValue, int maxValue)
    {
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(minValue, maxValue);
        }
    }

    public void PrintArray()
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        OneDimensionalArray myArray = new OneDimensionalArray(100);

        myArray.FillWithRandomNumbers(-50, 51);

        Console.WriteLine("Початковий масив:");
        myArray.PrintArray();

        myArray.ReplaceNegativesWithAbs();

        Console.WriteLine("Масив після заміни від'ємних елементів на модулі:");
        myArray.PrintArray();
    }
}
