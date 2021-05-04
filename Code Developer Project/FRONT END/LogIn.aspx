<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="FRONT_END.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="margin:auto;border:5px solid white;">
        <tr><td> <br /> </td></tr>
        <tr>
            
            <td>
                <asp:Label ID="lbUserName" runat="server" Text="UserName"></asp:Label></td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>  </td>    
                                 
        </tr>
      <tr>
          <td>
              <br />
          </td>
      </tr>
         <tr>
            <td> <asp:Label ID="lbPassword" runat="server" Text="Password"></asp:Label></td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
             
            </td>        
        </tr>
         <tr> 
            <td><asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click"></asp:Button></td>
            
        </tr>
        <tr>
            <td><asp:Label ID="lbErro" runat="server" Text="UserName ou Password Incorrectas." ForeColor="Red"></asp:Label></td>
        </tr>
        <tr><td>
            <br />
        </td></tr>
           <tr> 
            <td><ul>
                    <li style="font-size:17px; font-display:block; font-weight:bold;"><a runat="server" href="CriarUtilizador.aspx">Ainda não tem conta? Clique aqui!</a></li>
                </ul>

            </td>
            
        </tr>
    </table>
</asp:Content>
