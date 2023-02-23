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

int SumNumber(int a)
{
    int result = 0;
    int sum = 0;
    string size = Convert.ToString(a);

    for (int i = 0; i < size.Length; i++)
    {
        result = a % 10;
        a = a / 10;
        sum = sum + result;

    }

    return sum;
}

int readNumber = ReadNumber();
int sumNumber = SumNumber(readNumber);
Console.WriteLine($"Сумма цифр в числе {readNumber} = {sumNumber}");