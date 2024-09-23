float one, two, result;
char sign;
Console.Write("Введите первое число: ");
one  = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите операцию: ");
sign = Convert.ToChar(Console.ReadLine());
Console.Write("Введите второе число: ");
two = Convert.ToSingle(Console.ReadLine());

if (sign == '+')
{
    result = one + two;
    Console.WriteLine($"{one} {sign} {two} = {result}");
}
else if (sign == '-')
{
    result = one - two;
    Console.WriteLine($"{one} {sign} {two} = {result}");
}
else if (sign == '*')
{
    result = one * two;
    Console.WriteLine($"{one} {sign} {two} = {result}");
}
else if (sign == '/')
{
    if (two == 0)
    {
        Console.WriteLine("Ошибка. На ноль делить нельзя");
    }
    else if (sign == '/')
    {
        result = one / two;
        Console.WriteLine($"{one} {sign} {two} = {result}");

    }
}
else
{
    Console.WriteLine("Ошибка. Данная операция не поддерживается");
}