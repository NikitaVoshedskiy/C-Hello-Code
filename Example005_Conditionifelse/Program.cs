﻿Console.WriteLine("Ввкдите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{

    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}