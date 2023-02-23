Console.WriteLine("Введите число");
bool check = false;
int number = 0;
int res = 0;
int ReadNumber()
{
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            check = true;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}

int numberOne = ReadNumber();

Console.WriteLine("Введите степень числа");

int numberDegree = ReadNumber();

int Degree(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result = a * result;
    }

    return result;
}

res = Degree(numberOne, numberDegree);

Console.WriteLine($"Число {numberOne} в степени {numberDegree} = {res}");