<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FRONT_END._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
     
        div {
            font-family:'Segoe UI';
            font-size:17px;
        }

        a:link, a:visited, a:hover, a:active {
            color: #0e334e;
            text-decoration: none;
        }
    </style>
    <div class="jumbotron" style="text-align:center;">
        <h1 style="font-size:60px; background-color:#8e7800">Super-Receitas</h1>
        <p class="lead">Bem-vindos às Super-Receitas! O sítio onde vão puder encontrar as mais variadas e "saudáveis" receitas. Não percam mais tempo procurem já a vossa preferida! =)</p>
     </div>
    <br /> <br />
   <div style="text-align:center;">
       <asp:TextBox runat="server" ID="txtProcurar" Width="350" OnTextChanged="txtProcurar_TextChanged"></asp:TextBox>
       <br /> <br />
       <asp:Button ID="btnProcurar" runat="server" Text="Procurar" />
   </div>
    <br /> <br />
    <div>
        <br />
        <br />
        <br />
        <asp:GridView ID="gvReceitas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="gvReceitas_RowDataBound" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome"/>
                <asp:TemplateField HeaderText="Imagem">
                    <ItemTemplate>
                        <asp:Image ID="Imagem1" runat="server" Height="150px" Width="250px" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("Imagem")) %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
    <br /> <br />         
    </div>

</asp:Content>
