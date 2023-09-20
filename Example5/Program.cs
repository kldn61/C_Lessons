// Создание программы по приветствию любимчика

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Helen")
{
    Console.WriteLine("ПРИВЕТ КРАСОТКА!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}