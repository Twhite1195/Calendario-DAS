using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Clase que contiene los servicios ultizados por el usuario
/// </summary>
public class UserServices : IUserServices
{
    public static List<User> Users = new List<User>();
    public static int Id = 0;
    /// <summary>
    /// Metodo que recibe la informacion necesaria para crear un usuario y agregarlo a la lista de usuarios
    /// </summary>
    /// <param name="user"></param>
    /// <param name="pass"></param>
    /// <returns></returns>
    public bool CreateUser(string user, string pass)
    {
        bool crear = false;
        Users.Add(new User(user, pass, Id));
        Id = Id + 1;
        crear = true;
        return crear;
    }
    /// <summary>
    /// Metodo que recibe el usuario y contraseña del usuario y verifica si existe en el sistema
    /// </summary>
    /// <param name="user"></param>
    /// <param name="pass"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Metodo que recibe el recordatorio del usuario y lo agrega a los recordatorios del cliente
    /// </summary>
    /// <param name="aux"></param>
    /// <returns></returns>
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