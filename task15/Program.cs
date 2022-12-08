//программа принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
    {
        Console.WriteLine("Рабочий день");
    }    
    else
        {
            Console.WriteLine("Выходной день");
        }
 