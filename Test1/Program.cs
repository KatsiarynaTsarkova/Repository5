// Программа принимает на вход два числа а и в, и возводит а в степень в.
Console.WriteLine("Введите число A ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число размера степени В ");
int b = int.Parse(Console.ReadLine());
double c = Math.Pow(a, b);
Console.WriteLine($"c ={c } ");
