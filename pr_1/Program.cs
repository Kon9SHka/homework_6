Console.Clear();

int size_number = GetNumberFromUser("Введите количество чисел: ");
int[] array = GetArray(size_number);
int count = GetPossitiveNumbers(array);
Console.WriteLine($"В массиве: [{String.Join(", ",array)}]");
Console.WriteLine($"{count} чисел больше 0");


int GetNumberFromUser (string message) 
{
    while(true) 
    {

    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
    while(isCorrect)
        return number;
    Console.WriteLine("Ошибка ввода!");

    }
}

int[] GetArray (int size) 
{   
    int[] array = new int[size];
    for (int i = 0; i<size; i++) 
    {
      array[i] = GetNumberFromUser($"Введите {i+1} число: ");
    }
    return array;
}

int GetPossitiveNumbers (int[] array) 
{   
    int count = 0;
    foreach( int el in array) 
    {
        if (el > 0)
        count = count + 1;
    }
    return count;
}
