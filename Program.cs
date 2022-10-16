using static System.Console;
Write("Введит количество строк");
int lines = Convert.ToInt32(ReadLine()!);
Write("Введит количество cтолбцов");
int colums = Convert.ToInt32(ReadLine()!);
double[,] numbers = new double[lines, colums];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine(" ");
    }
}