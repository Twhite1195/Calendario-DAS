using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public static IUserServices userServices = new UserServices();
    protected void BntLogin_Click(object sender, EventArgs e)
    {
        string nameUser = TxtNombre.Text;
        string passwordUser = TxtContra.Text;
        Login(nameUser, passwordUser);
    }

    protected void BntCrear_Click(object sender, EventArgs e)
    {
        string nameUser = TxtNombre.Text;
        string passwordUser = TxtContra.Text;
        bool crearUsuario = userServices.CreateUser(nameUser, passwordUser);
        if (crearUsuario)
        {
            Login(nameUser, passwordUser);
        }
        else
        {

        }
    }

    public void Login(string nombre, string passworld)
    {
        Session.Add("1", userServices);
        Response.Redirect("Reminder.aspx");
       
    }
}