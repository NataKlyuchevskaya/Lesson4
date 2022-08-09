void Zadacha25()
{
// Используя определение степени числа, напишите цикл, который принимает на вход 
//два натуральных числа (A и B) и возводит число A в степень B.

Console.WriteLine("Введите чило А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило B:  ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    result *= A;
}
Console.WriteLine($"число А возведенное в степень В равно:{result}");
}


void Zadacha27()
{
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.  452 -> 11, 82 -> 10, 9012 -> 12
int number = 9012;
SumOfDigits(number);
}

void Zadacha29()
{
//Напишите программу, которая задаёт массив из 8 случайных целых чисел и 
//выводит отсортированный по модулю массив.  -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33] 
int size = 8;
int [] array = new int[size];
FillArray(array);
PrintArray(array);
Sort(array);
PrintArray(array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next (-10, 11);
        }
}


void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write( array[i] + "  ");
        }
    Console.WriteLine();
}


void Sort(int[] array)
{
for (int i = array.Length - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
        if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }

}



void SumOfDigits(int number)
{
    int sum = 0;
    Console.Write("Сумма цифр числа " + number);
    while (number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine(" равна " + sum);
}


//Zadacha25();
//adacha27();
Zadacha29();