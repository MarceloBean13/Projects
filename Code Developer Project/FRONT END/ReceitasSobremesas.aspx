<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceitasSobremesas.aspx.cs" Inherits="FRONT_END.ReceitasSobremesas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="titulo">
        <h2>Receitas de Sobremesas</h2>
    </div>
    <br /> <br />
    <div id="receitas">
        <asp:DataList ID="dlReceitas" runat="server">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>

                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
