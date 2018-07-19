using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Objeto que contiene la informacion del Recordatorio
/// </summary>
public class Reminder
{
    public string Description { get; set; }
    public DateTime ReminderDate { get; set; }
    public int UserId { get; set; }
    /// <summary>
    /// Constructor del objeto recordatorio
    /// </summary>
    /// <param name="Des"></param>
    /// <param name="Remind"></param>
    /// <param name="Id"></param>
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