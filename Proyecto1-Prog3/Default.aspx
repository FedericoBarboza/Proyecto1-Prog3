<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto1_Prog3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="buscar" runat="server" Text="Buscar" OnClick="buscar_Click" />
&nbsp;&nbsp;&nbsp;<asp:Button ID="guardar" runat="server" OnClick="guardar_Click" Text="Guardar" />
    &nbsp;
    <asp:Button ID="lista" runat="server" Text="Listar" OnClick="lista_Click" />
    &nbsp;&nbsp;
    <asp:Button ID="eliminar" runat="server" OnClick="eliminar_Click" Text="Eliminar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="deptoCap" runat="server" OnClick="deptoCap_Click" Text="CapDepartamento" />
    <br />
    <asp:GridView ID="gridDepto" runat="server">
    </asp:GridView>


    <br />
    <asp:TextBox ID="txtDepto" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Emp" runat="server" OnClick="Emp_Click" Text="Empleado" />
    <asp:Label ID="Label3" runat="server"></asp:Label>


    <asp:GridView ID="empGrid" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Listar" />


</asp:Content>
