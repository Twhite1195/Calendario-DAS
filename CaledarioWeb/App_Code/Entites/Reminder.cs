using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Reminder
/// </summary>
public class Reminder
{
    public string Description { get; set; }
    public DateTime ReminderDate { get; set; }
    public int UserId { get; set; }

    public Reminder(String Des, DateTime Remind, int Id)
    {
        Description = Des;
        ReminderDate = Remind;
        UserId = Id;
    }

    public override string ToString()
    {
        return "Recordatorio\n" + "Id: " + UserId + " Recordatorio: " + Description + " Fecha: " + ReminderDate;
    }
}