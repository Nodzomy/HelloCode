﻿Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine();

if (username.ToLower() == "миша")
{
    Console.WriteLine("Ура, это же Миша!");
}
else
{
    Console.Write("Првиет, ");
    Console.WriteLine(username);
}