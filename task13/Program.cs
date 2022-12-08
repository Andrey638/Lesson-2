//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите трехзначное число");
    while(true)
    {
        string input = Console.ReadLine();
    if (input.Length < 3) 
            Console.WriteLine("число не трёхзначное");
        else
            Console.WriteLine("{0}->{1}",input, input[2]);
            break;   
    }
