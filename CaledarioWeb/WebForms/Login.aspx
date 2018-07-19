<%@ Page Title="" Language="C#" MasterPageFile="~/mpg.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="WebForms_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 76%;
            height: 144px;
        }
        .auto-style2 {
            width: 291px;
            text-align: center;
        }
        .auto-style4 {
            width: 291px;
            height: 23px;
            text-align: center;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style6" colspan="2">Login</td>
        </tr>
        <tr>
            <td class="auto-style4">Nombre</td>
            <td class="auto-style5">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Contraseña</td>
            <td>
                <asp:TextBox ID="TxtContra" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">
                <asp:Button ID="BntCrear" runat="server" OnClick="BntCrear_Click" Text="Crear" />
&nbsp;&nbsp;
                <asp:Button ID="BntLogin" runat="server" OnClick="BntLogin_Click" style="height: 26px" Text="Login" />
            </td>
        </tr>
    </table>
</asp:Content>

