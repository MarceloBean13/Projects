<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imagens.aspx.cs" Inherits="FRONT_END.Imagens" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            titulo
            <asp:TextBox ID="txtTítulo" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:FileUpload ID="fuImagem" runat="server" />
        </div>
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Button" />
    </form>
</body>
</html>
