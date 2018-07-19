using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarioEntites;

namespace CalendarioServices
{
    public class UserServices : UserInterface
    {
        public static List<CalendarioEntites.User> Users = new List<CalendarioEntites.User>();
        public static int Id = 0;

        public bool CreateUser(string user, string pass)
        {
            Boolean crear = false;
            Users.Add(new CalendarioEntites.User(user, pass, Id));
            Id = Id + 1;
            crear = true;
            return crear;
        }
        public CalendarioEntites.User Login(string user, string pass)
        {
            CalendarioEntites.User userAux = null;
            for (int i = 0; i < Users.Count(); i++)
            {
                if (user == Users[i].UserName && pass == Users[i].PassWord)
                {
                    userAux = Users[i];
                }

            }
            return userAux;
        }
        public bool PostReminder(Reminder aux)
        {
            bool publicacion = false;

            for (int i = 0; i < Users.Count(); i++)
            {
                if (Users[i].Id == aux.UserId)
                {
                    Users[i].reminders.Add(aux);
                    publicacion = true;
                }
            }
            return publicacion;

        }
    }
}

