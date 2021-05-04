<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarUtilizador.aspx.cs" Inherits="FRONT_END.CriarUtilizador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Criar Novo Utilizador</h3>
    <br /> <br />

    <table class="nav-justified" style="font-family:'Segoe UI'">
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px">Nome:&nbsp; </td>
            <td class="modal-sm" style="width: 256px">
                <asp:TextBox ID="txtNome" runat="server" Width="250px"></asp:TextBox>
                <br />
            </td>
            <td class="text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="height: 20px; width: 488px; font-size: 17px">Último Nome:&nbsp;</td>
            <td style="height: 20px; width: 256px;">
                <asp:TextBox ID="txtUltimoNome" runat="server" Width="250px"></asp:TextBox>
                <br />
            </td>
            <td style="height: 20px" class="text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUltimoNome" ErrorMessage="Último Nome é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px; height: 25px;">E-mail:&nbsp;</td>
            <td class="modal-sm" style="width: 256px; height: 25px">
                <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                <br />
            </td>
            <td class="text-left" style="height: 25px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail não é válido" Font-Size="17px" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; height: 15px; font-size: 17px">UserName:&nbsp;</td>
            <td style="height: 15px; width: 256px;">
                <asp:TextBox ID="txtUsername" runat="server" Width="250px" AutoPostBack="True" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
                <br />
            </td>
            <td style="height: 15px" class="text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUsername" ErrorMessage="UserName é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lbUsernameExiste" runat="server" Font-Size="17px" ForeColor="#FF3300" Visible="False"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px">Password:&nbsp;</td>
            <td class="modal-sm" style="width: 256px">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                <br />
            </td>
            <td class="text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px">Confirmar Password:&nbsp;</td>
            <td class="modal-sm" style="width: 256px">
                <asp:TextBox ID="txtConfirPass" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                <br />
            </td>
            <td class="text-left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtConfirPass" ErrorMessage="Confirmar Password é obrigatório" Font-Size="17px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirPass" ErrorMessage="Password não é igual" Font-Size="17px" ForeColor="#FF3300"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px; height: 35px;"></td>
            <td class="modal-sm" style="width: 256px; height: 35px;">
                <asp:Button ID="Button1" runat="server" Font-Size="17px" OnClick="Button1_Click" Text="Criar" Width="70px" />
                </td>
            <td style="height: 35px"></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 488px; font-size: 17px; height: 35px;">&nbsp;</td>
            <td class="modal-sm" style="width: 256px; height: 35px;">
                <asp:Label ID="lbSucesso" runat="server" Font-Size="17px" ForeColor="Lime" Text="Utilizador Criado com Sucesso" Visible="False"></asp:Label>
                <br />
            </td>
            <td style="height: 35px">&nbsp;</td>
        </tr>
    </table>

    <table border="0">
    </table>
</asp:Content>
