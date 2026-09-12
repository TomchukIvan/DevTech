Console.WriteLine("ПАНЕЛЬ ВЫЧИСЛЕНИЯ СРЕДНЕГО ЗНАЧЕНИЯ");

Console.Write("Введите пять оценок Студента1: ");
var t1 = Console.ReadLine().Split(' ');
double s1 = 0;

for (int i = 0; i < 5; i++) s1 += double.Parse(t1[i]);

Console.Write("Введите пять оценок Студента2: ");
var t2 = Console.ReadLine().Split(' ');
double s2 = 0;

for (int i = 0; i < 5; i++) s2 += double.Parse(t2[i]);

Console.Write("Введите пять оценок Студента3: ");
var t3 = Console.ReadLine().Split(' ');
double s3 = 0;

for (int i = 0; i < 5; i++) s3 += double.Parse(t3[i]);

Console.WriteLine($"Средняя оценка: Студент1 {s1 / 5} Студент2 {s2 / 5} Студент3 {s3 / 5}");