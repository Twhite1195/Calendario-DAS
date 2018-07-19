public interface IUserServices
{
    bool CreateUser(string user, string pass);
    User Login(string user, string pass);
    bool PostReminder(Reminder aux);
}