// y = k1 * x + b1, y = k2 * x + b2
// 2 5 4 9

double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);

    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"{x}, {y}");