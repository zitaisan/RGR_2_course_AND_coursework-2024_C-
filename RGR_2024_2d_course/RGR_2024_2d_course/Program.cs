using RGR_2024_2d_course;
using System;
using System.ComponentModel.DataAnnotations;

//вычисление гармонической функции 
int step = 1;
double m_x(int a, int b, int x)
{
    if (((b - a) <= x) && (x < (b + a)))
        return (0.5 * (1 + Math.Cos(Math.PI * (x - b) / a))); //гармоническая функция
    else return 0;
}

value[] results(int a, int b) //функция для получения нечетких чисел после обработки гармонической функции
{
    value[] digitals = new value[2 * a + 1];
    int x = b - a;
    int i = 0;
    Console.WriteLine("Обработка нечетких чисел после гармонической функции");
    while (x <= (b + a))
    {
        double y = m_x(a, b, x); //получаем значения гармонической функции
        var d = new value(x, y); //записываем в структуру запоминания значения функции и аргумент
        digitals[i] = d; //добавляем значение в массив
        x += step; // следующее число
        i++;
        Console.Write(x + ": " + Math.Round(y, 2).ToString() + "; ");
    }
    Console.WriteLine();
    return digitals;
}
int method(value[] result)
{
    int MethodResult = 0;
    double upper_res = 0;
    double lower_res = 0;
    for (int i = 0; i < result.Length; i++)
    {
        upper_res += result[i].x * result[i].y; //обрабатываем согласно методу
        lower_res += result[i].y;
    }
    MethodResult = Convert.ToInt32(upper_res / lower_res);
    return MethodResult;
}
BinaryTree add_new(int a, int b, BinaryTree tree)
{
    Console.WriteLine("a " + a + "  b " + b);
    var res = new value[2 * a + 1];
    int val;
    res = results(a, b);
    val = method(res);
    Console.WriteLine("После обработки методом: " + val);
    Console.WriteLine("Место в дереве");
    tree.Add(val);
    Console.WriteLine("-------------------------");
    return tree;
}

BinaryTree tree = new BinaryTree();
try
{
    string filePath = "C:\\Users\\taisi\\source\\repos\\RGR_2024_2d_course\\RGR_2024_2d_course\\arguments.txt";
    if (File.Exists(filePath))
    {
        //Pass the file path and file name to the StreamReader constructor
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            int c = 0;
            while ((line = sr.ReadLine()) != null)
            {
                string[] subs = line.Split(' ');
                int a = int.Parse(subs[0]);
                int b = int.Parse(subs[1]);
                tree = add_new(a, b, tree);
                c++;
            }
            if (c<7)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Введите не менее семи элементов");
                return;
            }
        }     
        Console.WriteLine("\nВизуализация дерева:");       
        tree.PrintTree();
    }
    Console.WriteLine("Для добавления в дерево, введите параметры");
    Console.WriteLine("параметр a");
    int an = int.Parse(Console.ReadLine());
    Console.WriteLine("параметр b");
    int bn = int.Parse(Console.ReadLine());
    if ((an <= bn)&&((an)>0))
    {
        Console.WriteLine("\nВизуализация дерева:");
        add_new(an, bn, tree).PrintTree();
    }
    else { Console.WriteLine("Допускаются неотрицательные числа, где a<b"); }
}
catch (Exception e)
{
    Console.WriteLine("Ошибка: " + e.Message);
}
finally
{
    Console.WriteLine("Программа отработала!!!!");
}

