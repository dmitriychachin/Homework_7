/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
            matrix[i, j ] = rnd.Next(-5,10);
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


//Вычисление среднеарифметического столбца
void arithmeticMeanColum(double[,] matrix, int x, int y)
{
    double amc = 0;
    int n = 0;
    for (int j = 0; j < y; j++)
    {
        int i = 0;
        double sum = 0;
        while (i < x)
        {
            sum += matrix[i, j];
            i += 1;
        }
        amc = sum / x;
        Console.WriteLine($"Среднеарифметическое столбца {n += 1} равна {amc}");
    }
}


int x = GetNumber("Введите количество строчек:");
int y = GetNumber("Введите количество столбцов:");
double [,]matrix = createMatrix(x,y);
PrintMatrix(matrix);
Console.WriteLine();
arithmeticMeanColum(matrix, x, y);