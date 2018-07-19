using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioServices
{
    public interface UserInterface
    {
        bool CreateUser(String user, String pass);
        CalendarioEntites.User Login(String user, String pass);
        bool PostReminder(CalendarioEntites.Reminder aux);
    }
}
