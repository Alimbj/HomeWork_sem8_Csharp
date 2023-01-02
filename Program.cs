// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();


//Доашнее задание №54
/*
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
inputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++){

                if (matrix[i, k] < matrix[i, k+1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k+1];
                    matrix[i, k+1] = temp;
                }
            }
        }
    }
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
*/


//Домашнее задание №56
//Какая то чушь
/*
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101); // [1, 100]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


var array = new List<int> {};
int sum = 0, min = 0;
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
inputMatrix(matrix);
for (int i = 0; i < matrix.GetLength(1); i++)
    min += matrix[0, i];

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array.Add(sum);
        if (min > sum); 
            min = sum;
    }
// Это скопировано с ношиона, выше написано рукой то же самое, но работают по разному
for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (min > sum)
            min = sum;
    }

Console.WriteLine(min);
Console.WriteLine(sum);
foreach (int element in array)  //Выведем элементы созданного списка
{
    Console.Write($"[{element}] ");
}
*/
        

// Домашнее задание №58
/*
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void inputMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix2[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив 1");
inputMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив 2");
inputMatrix2(matrix2);
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix2[i, j] * temp;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
*/

//Домашнее задание №60, списал в ношионе
/*
void InputMatrix(int[,,] ThreeMatrix)
{
    int number = 10;
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
                ThreeMatrix[i, j, k] = number++; 
        }
    }
}


void PrintMatrix(int[,,] ThreeMatrix)
{
    for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
                Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
        }
    }
}


Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
InputMatrix(ThreeMatrix);
PrintMatrix(ThreeMatrix);
*/


