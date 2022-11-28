Console.Write("введите свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "леонид") //tolower для ввода в любом регистре инахождения равенства символов
    {
    Console.WriteLine("ооу здорова Леонид");
    }
else
    {
    Console.Write("Привет, ");
    Console.WriteLine(username);
    }