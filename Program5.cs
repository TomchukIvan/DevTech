Console.WriteLine("ПАНЕЛЬ СОСТАВЛЕНИЯ ДВУХ МАТРИЦ");
Console.Write("Введите 9 чисел через пробел: ");
int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

// Создание первой матрицы 3х3 и заполнение её по строкам
int[,] matrix1 = new int[3, 3];
for (int i = 0; i < 9; i++) 
    matrix1[i / 3, i % 3] = numbers[i];

// Создание второй матрицы
int[,] matrix2 = new int[3, 3];
for (int r = 0; r < 3; r++)
    for (int c = 0; c < 3; c++)
        matrix2[c, r] = matrix1[r, c];

// Вывод первой и второй матрицы на экран
Console.WriteLine("\n1-матрица: 2-матрица:");
for (int r = 0; r < 3; r++)
    Console.WriteLine($"{matrix1[r, 0]} {matrix1[r, 1]} {matrix1[r, 2]}     |    {matrix2[r, 0]} {matrix2[r, 1]} {matrix2[r, 2]}");