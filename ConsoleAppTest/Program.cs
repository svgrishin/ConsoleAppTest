using Figures;

Console.WriteLine("Введите стороны треугольника:");
Console.WriteLine("Сторона 1: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сторона 2: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сторона 3: ");
double c = Convert.ToDouble(Console.ReadLine());

List<Figure> figures = new List<Figure>();
figures.Add(new Triangle(a, b, c));

Figure triangle = new Triangle(a, b, c);

Console.WriteLine($"Площать треугольника: {figures[0].GetS()}");

Console.WriteLine(figures[0].GetDescription());


//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
