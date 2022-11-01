Console.Clear();

double k1 = GetNumberFromUser("Введите k1: ");
double b1 = GetNumberFromUser("Введите b1: ");
double k2 = GetNumberFromUser("Введите k2: ");
double b2 = GetNumberFromUser("Введите b2: ");
Console.WriteLine($"X - {GetX(k1,b1,k2,b2)}");
Console.WriteLine($"Y - {GetY(k1,b1,k2,b2)}");

Console.WriteLine($"Точка пересечения двух прямых -> ({GetX(k1,b1,k2,b2)}, {GetY(k1,b1,k2,b2)})");


double GetNumberFromUser (string message) 
{
    while(true) 
    {

    Console.Write(message);
    bool isCorrect = double.TryParse(Console.ReadLine(), out double number);
    while(isCorrect)
        return number;
    Console.WriteLine("Ошибка ввода!");

    }
}

double GetX (double k1, double b1, double k2, double b2) 
{
    //Поскольку стоит задача найти точки пересечения, приравниваем уравнения друг к другу и находим х
    //k1*x + b1 = k2*x + b2
    //k1*x - k2*x = b2 - b1
    //x= -(b2 - b1)/(k1-k2)
    double x = Convert.ToDouble(-(b1-b2)/(k1-k2));
    return x;
} 

double GetY (double k1, double b1, double k2, double b2) 
{
    double x = GetX (k1,b1,k2,b2);
    double y = Convert.ToDouble(k1*x+b1);
    return y;
}
