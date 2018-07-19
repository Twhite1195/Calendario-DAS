/// <summary>
/// Iterfaz utilizada por los servicios del usuario 
/// </summary>
public interface IUserServices
{
    bool CreateUser(string user, string pass);
    User Login(string user, string pass);
    bool PostReminder(Reminder aux);
}