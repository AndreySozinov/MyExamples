Console.Clear();
Console.WriteLine("Введите свое имя");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Моё почтение, господин!");
}
else
{
    Console.Write("Ну, привет, ");
    Console.WriteLine(username);
}

Console.WriteLine("Чему могу помочь?");
