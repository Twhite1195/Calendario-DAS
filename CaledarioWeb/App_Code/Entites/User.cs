using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Objeto que contiene la informacion del usuario
/// </summary>
public class User
{
    public string UserName { get; set; }
    public string PassWord { get; set; }
    public int Id { get; set; }
    public List<Reminder> reminders = new List<Reminder>();
    /// <summary>
    /// Constructor del objeto usuario
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="passWord"></param>
    /// <param name="id"></param>
    public User(string userName, string passWord, int id)
    {
        UserName = userName;
        PassWord = passWord;
        Id = id;
    }
}