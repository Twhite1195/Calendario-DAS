using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserServices
/// </summary>
public class UserServices : IUserServices
{
    public static List<User> Users = new List<User>();
    public static int Id = 0;

    public bool CreateUser(string user, string pass)
    {
        bool crear = false;
        Users.Add(new User(user, pass, Id));
        Id = Id + 1;
        crear = true;
        return crear;
    }
    public User Login(string user, string pass)
    {
        User userAux = null;
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