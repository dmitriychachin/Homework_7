/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число или 0. Введите корректное число");
}
}

return result;
}

//Создание массива
double [,] createMatrix(int x, int y)
{
    double[,] matrix = new double[x,y];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j ] = rnd.Next();
        }
    }

    return matrix;
}

void PrintMatrix(double [,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
}

//Поиск элемента по указанной позиции
void findElement(int x, int y, double [,] matrix)
{

    double element = 0;

    if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1))
    {
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            element = matrix[i, j ];
        }
    }
    Console.WriteLine($"Элемент имеет значение {element}");
    }
    else 
    {
        Console.WriteLine("Такого числа в массиве нет");
    }

}

int x = GetNumber("Введите количество строчек:");
int y = GetNumber("Введите количество столбцов:");
double [,]matrix = createMatrix(x,y);
PrintMatrix(matrix);

int m = GetNumber("Введите строчку элемента:");
int n = GetNumber("Введите столбец элемента:");

findElement(m, n, matrix);