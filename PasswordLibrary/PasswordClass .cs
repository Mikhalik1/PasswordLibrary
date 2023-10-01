using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibrary
{


    public class PasswordClass
    {
        /// <summary>
        /// В качестве параметра передается строка - пароль
        /// </summary>
        /// <param name="password"></param>
        /// <returns>
        /// Метод возвращает целое число, соответствующее сложности пароля
        /// </returns>
        public static int PasswordStrengthCheker(string password)
        {

            if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password) || Regex.Match(password, "[ ]").Success)//проверка пустоту
            {
                throw new Exception("пустое значение");
            }

            int result = 0;
            if (password.Length > 7) //проверка что пароль состоит из больше семи символов
            {
                result++;
            }

            if (Regex.Match(password, "[0-9]").Success)  //проверка что пароле есть цифры от 0 до 9
            {
                result++;
            }

            if (Regex.Match(password, "[a-z]").Success) //проверка что пароле есть буквы в нижнем регистре
            {
                result++;
            }

            if (Regex.Match(password, "[A-Z]").Success)//проверка что пароле есть буквы в верхнем регистре
            {
                result++;
            }

            if (Regex.Match(password, "[\\?\\!\\@\\#\\$\\%\\&\\(\\)\\{\\}\\[\\]\\,\\,\\'\\:\\;\\+\\=\\-\\<\\>]").Success) //проверка что пароле есть спец символы
            {
                result++;
            }
            
            if (Regex.Match(password, "[а-яА-Я]").Success) //проверка на наличие кирилицы в пароле, выдаёт ошибку
            {
                throw new Exception("Кириллические символы запрещены при вводе пароля");
            }

            return result;
        }
    }
}
