Main ();

void Main ()
{
    bool Home_Work = true;
    while(Home_Work)
    {
        System.Console.WriteLine("Enter task number or exit ");
        string task_number = Console.ReadLine();
        switch(task_number)
        {
            case "1": task001();
            break;

            case "2": task002();
            break;

            case "3": task003();
            break;

            case "exit": Home_Work = false;
            break;

            default: Console.WriteLine("Invalid input. Repeat");
            break;
        }
    }
}

//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void task001()
{
    int m = IntRead("number of line");
    int n = IntRead("number of columns");
    int min = IntRead("minimum value in array");
    int max = IntRead("maximal value in array");

    GetDoubleArray(GetArray(m,n,min,max),m,n);
}

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента не существует 
void task002()
{
    int m = IntRead("number of line");
    int n = IntRead("number of columns");
    int min = IntRead("minimum value in array");
    int max = IntRead("maximal value in array");
    int index = IntRead("index");

    while (index < 10 || index > 99)
    {
        System.Console.WriteLine("This is an invalid index");
    }


}

void task003()
{

}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"input {argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not a number!!! Try again: ");
    }
    return number;
}

double[,] GetDoubleArray(int[,] array, int m, int n)
{
    double[,] numbers = new double[m,n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i,j] = new Random().NextDouble() * array[i,j];
            System.Console.Write($"{Math.Round(numbers[i,j],2)} ");
        }
        System.Console.WriteLine();
    }
    return numbers;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
    return array;
}

int[,] GetPrintArray(int m, int n, int min, int max)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min,max);
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return array;
}

int SearchByIndex(int[,] array)
{

}