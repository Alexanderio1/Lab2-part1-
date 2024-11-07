using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Extensions
    {
        public static char Highlighter(this string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine("Строка имеет четное количество символов");
                return text[(text.Length / 2)];
            }
            return text[(text.Length / 2) ];
            
            
        } 

        public static string CheckPassword(this Password p1)
        {
            if(p1.value.Length>=6 && p1.value.Length <= 12)
            {
                return ("Пароль имеет допустимую длину");
            }
            else
            {
                return ("Длина пароля должна быть в пределах от 6 до 12 символов");
            }
        }
    }
}
