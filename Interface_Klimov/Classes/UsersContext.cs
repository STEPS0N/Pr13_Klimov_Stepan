using Interface_Klimov.Interfaces;
using Interface_Klimov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Klimov.Classes
{
    public class UsersContext : Users, IUsers
    {
        public List<Users> AllUsers;

        public UsersContext() =>
            this.All(out AllUsers);

        public void All(out List<Users> Users)
        {
            Users = new List<Users>();
            AllUsers.Add(new Users(1, "Аликина Ольга"));
            AllUsers.Add(new Users(2, "Бояркин Данил"));
            AllUsers.Add(new Users(3, "Бурмантов Владислав"));
            AllUsers.Add(new Users(4, "Дылдин Максим"));
            AllUsers.Add(new Users(5, "Евдокимов Даниил"));
            AllUsers.Add(new Users(6, "Костюнин Никита"));
            AllUsers.Add(new Users(7, "Кучин Данил"));
            AllUsers.Add(new Users(9, "Мотырев Александр"));
            AllUsers.Add(new Users(10, "Мухридинов Далер"));
            AllUsers.Add(new Users(11, "Олейник Владимир"));
            AllUsers.Add(new Users(12, "Саблин Константин"));
            AllUsers.Add(new Users(13, "Субботин Валерий"));
            AllUsers.Add(new Users(14, "Сукрушев Егор"));
            AllUsers.Add(new Users(15, "Торсунов Даниил"));
            AllUsers.Add(new Users(16, "Хабибрахманов Никита"));
            AllUsers.Add(new Users(17, "Хикматулин Григорий"));
            AllUsers.Add(new Users(18, "Черенев Сергей"));
            AllUsers.Add(new Users(19, "Чупин Дмитрий"));
            AllUsers.Add(new Users(20, "Шилов Дмитрий"));
        }
    }
}
