Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "maletos")
{
    Console.WriteLine("приветствую, мой Господин");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}