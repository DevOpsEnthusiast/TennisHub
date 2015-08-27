<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPlayer.aspx.cs" Inherits="tpMTM.AddPlayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <br />
    Phone:<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    <br />
    Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAdd" Text="Add" runat="server" onclick="btnAdd_Click"/>
</asp:Content>
