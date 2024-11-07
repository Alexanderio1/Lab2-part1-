using Lab2;
using System;
using System.Threading;

{
    Password p1 = new Password ();
    Password p2 = new Password();


    bool isInactive = false;
    Timer timer = new Timer((e) =>
    {
        isInactive = true;
    }, null, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(-1));
    while (!isInactive)
    {
        Console.WriteLine("Введите пароль");
        p1.value = Console.ReadLine();
        Console.WriteLine("Введите второй пароль");
        p2.value = Console.ReadLine();
        Console.WriteLine("Тест перегруженных операций:");
        Console.WriteLine($"1)Замена последнего символа: password1-'a' = {(p1 - 'a').value}");
        Console.WriteLine($"2)Сравнение длин паролей: password1<password2 = {p1 < p2}");
        Console.WriteLine($"3)Проверка паролей на неравенство: password1!=password2 = {p1 != p2}");
        Console.WriteLine($"4)Сброс пароля на значение по умолчанию: ++password1 = {(++p1).value}");
        Console.WriteLine($"5)Проверка пароля на стойкость: password2?true:false = {(p2 ? true : false)}\n");

        Console.WriteLine("Тест методов расширений:");
        Console.WriteLine($"1)Выделение среднего символа строки: password1-{p1.value.Highlighter()}, password2-{p2.value.Highlighter()}");
        Console.WriteLine($"2)Проверка допустимой длины пароля(6-12):\npassword1-{p1.CheckPassword()}\npassword2-{p2.CheckPassword()}");

        Console.WriteLine($"{p1.value}, {p2.value}");
        Console.ReadLine();
        Console.Clear();
    }
    
}

