<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceitasSopas.aspx.cs" Inherits="FRONT_END.ReceitasSopas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<style>
    *{
        font-family:'Segoe UI';
        font-size:17px;
    }
</style>
    <div>
        <br /> <br />
        <table>
            <tr>
                <td>
                    <asp:GridView runat="server" ID="dgvSopa" style="height:600px; width:300px; text-align:center;" AutoGenerateSelectButton="true"></asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
