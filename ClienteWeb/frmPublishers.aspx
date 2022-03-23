﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPublishers.aspx.cs" Inherits="ClienteWeb.frmPublishers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h3 style="font-family: 'Arial Narrow'; font-size: 40px; color: #000080">Tabla Publishers - Wilson Holguin</h3>
    <br />
    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p> Name: <asp:TextBox runat="server" Id="txtName"/></p>
    <p> City: <asp:TextBox runat="server" Id="txtCity"/></p>
    <p> State: <asp:TextBox runat="server" Id="txtState"/></p>
    <p> Country: <asp:TextBox runat="server" Id="txtCountry"/></p>
    <p>
        
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>

    </p>
    <p>
        <asp:GridView runat="server" Id="gvPublishers" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </p>

</asp:Content>
