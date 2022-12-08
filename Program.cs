//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*System.Console.WriteLine("Введите пятизначное число ");
string?num = Console.ReadLine();
if (num.Length == 5)
{
    if (num[0]==num[4] && num[1]==num[3])
    {
        System.Console.WriteLine($"число {num} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"число {num} не является палиндромом");
    }

}
else
{
    System.Console.WriteLine("Ошибка, введите пятизначное число");
}*/

//Задача 21.Напишите программу, которая принимает на вход координаты ???трех??? точек и находит расстояние между ними в 3D пространстве.

int[] point = new int[6];
System.Console.WriteLine("введите x1: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите x2: ");
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите y1: ");
point[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите y2: ");
point[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z1: ");
point[4] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z2: ");
point[5] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(point[1]-point[0],2)+Math.Pow(point[3]-point[2],2)+Math.Pow(point[5]-point[4],2)));

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=n; i++)
{
    System.Console.Write($"{i*i*i} ");
}*/
//Спасибо 