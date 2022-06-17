/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 14212 -> нет
 23432 -> да
 12821 -> да
*/
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}

/*Задача 21:Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.WriteLine("Введите координату x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());


double distant = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
Console.WriteLine(Math.Sqrt(distant));



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count =1;


while (count < n)
{
    int result = Cube(count);
    count++;
    Console.Write($"{result}, ");

} 
Console.WriteLine(Cube(n));
int Cube (int a)
{
    return a*a*a;
}

