<%@ Page Title="" Language="C#" MasterPageFile="~/mpg.master" AutoEventWireup="true" CodeFile="Reminder.aspx.cs" Inherits="WebForms_Reminder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Reminder</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:TextBox ID="TxtPost" runat="server" Height="49px" Width="506px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="BtnPost" runat="server" OnClick="BtnPost_Click" Text="Post" />
            </td>
        </tr>
    </table>
</asp:Content>

