<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarReceita.aspx.cs" Inherits="FRONT_END.Receitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script defer src="https://use.fontawesome.com/releases/v5.0.6/js/all.js"></script>
    <link href="Style.css" rel="stylesheet" />
    <br />
    <h1>Receitas</h1>
    <br /> <br /> <br />
    <table id="table1">
            <tr>
            <td style="width:250px; height:600px">
                &nbsp;
                <asp:GridView ID="dgvReceitas" runat="server" CellPadding="3" OnRowDataBound="dgvReceitas_RowDataBound" OnSelectedIndexChanged="dgvReceitas_SelectedIndexChanged" AutoGenerateSelectButton="True" style="margin-right: 0px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                    <Columns>
                          <asp:TemplateField HeaderText="Imagem">
                           <ItemTemplate>
                            <asp:Image ID="Imagem1" runat="server" Height="150px" Width="250px" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("Imagem")) %>'/>
                          </ItemTemplate>
                         </asp:TemplateField>
            </Columns>
                </asp:GridView>
            </td>
           <td style="width: 801px">
               &nbsp;&nbsp; Nome da Receita  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nível de Dificuldade<br />
               &nbsp;&nbsp; <asp:TextBox style="width:270px;" runat="server" ID="txtNomeReceita"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;             
                <asp:DropDownList runat="server" ID="ddlNivel" style="width:200px;"></asp:DropDownList>
               <br /> <br />
               &nbsp;&nbsp;Tipo de Cozinha&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tipo de Prato <br />
               &nbsp;&nbsp; <asp:DropDownList runat="server" ID="ddlTipoCozinha" style="width:200px;"></asp:DropDownList>
               &nbsp;&nbsp;
               &nbsp;&nbsp;<asp:DropDownList runat="server" ID="ddlTipoPrato" style="width:200px;"></asp:DropDownList>
               <br /> <br />
               &nbsp;&nbsp;Doses&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Tempo de Execução <br />
              &nbsp;
              <input runat="server" id="nuDoses" type="number" min="0" max="9999" style="width:100px;"/>
               &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList runat="server" ID="ddlTempo" style="width:200px;"></asp:DropDownList>
               <br /> <br /> 
               &nbsp;&nbsp;<asp:FileUpload ID="fuImagem" runat="server" style="text-align:center;"/>
               <br /> <br />
               &nbsp;&nbsp;
               Descrição <br />
               &nbsp;&nbsp;<asp:TextBox  ID="txtDescricao" runat="server" AutoCompleteType="None" BorderStyle="Solid" TextMode="MultiLine" ClientIDMode="Static" EnableTheming="True" Height="250px" ValidateRequestMode="Disabled" Width="770px"></asp:TextBox>
               <br /> <br /> <br />
               &nbsp;&nbsp;
               <asp:Button ID="btnGuardar" runat="server" Text="Guardar Receita" OnClick="btnGuardar_Click" />
                &nbsp;&nbsp;
               <asp:Button ID="btnModificar" runat="server" Text="Modificar Receita"/>
               <br /> <br />
               <br />
           </td>
        </tr>
        <tr>
            <td>
                <br /><br />
                <asp:GridView ID="gvIngredientes" runat="server" Width="250px" Height="200px" CellPadding="3" AutoGenerateSelectButton="True" OnRowDataBound="gvIngredientes_RowDataBound" OnSelectedIndexChanged="gvIngredientes_SelectedIndexChanged" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
            <td style="width: 801px">
                &nbsp; &nbsp;Nome Ingrediente <asp:TextBox runat="server" ID="txtNomeIngrediente" style="width:270px;"></asp:TextBox>
                &nbsp;&nbsp;
                Quantidade <input id="nuQuantidade" type="number" min="0" max="9999" style="width:100px;" runat="server"/>
                <br /> <br /> <br />
                &nbsp;&nbsp;
                Unidade de Medida <asp:DropDownList runat="server" ID="ddlUnidade" style="width:200px; justify-content:center;"></asp:DropDownList>
                <br /> <br /> <br />
                &nbsp;&nbsp;
                <asp:Button ID="btnGuardarIngrediente" runat="server" Text="Guardar Ingrediente" OnClick="btnGuardarIngrediente_Click" Visible="False" />
                &nbsp;&nbsp;
                <asp:Button ID="btnModificarIngrediente" runat="server" Text="Modificar Ingrediente" OnClick="btnModificarIngrediente_Click" Visible="False"/>
                &nbsp;&nbsp;
                <asp:Button ID="btnEliminarIngrediente" runat="server" Text="Eliminar Ingrediente" Visible="False" OnClick="btnEliminarIngrediente_Click"/>            

            </td>
        </tr>
    </table>
   </asp:Content>
