/*
 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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

int x = GetNumber("Введите количество строчек:");
int y = GetNumber("Введите количество столбцов:");
double [,]matrix = createMatrix(x,y);
PrintMatrix(matrix);