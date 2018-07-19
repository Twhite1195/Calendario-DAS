using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public string UserName { get; set; }
    public string PassWord { get; set; }
    public int Id { get; set; }
    public List<Reminder> reminders = new List<Reminder>();

    public User(string userName, string passWord, int id)
    {
        UserName = userName;
        PassWord = passWord;
        Id = id;
    }
}