<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Player.aspx.cs" Inherits="tpMTM.Player" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.
        
        <asp:GridView ID="gvPlayers" runat="server">
        </asp:GridView>
    </h2>
    <input type="text" runat="server" id="txtName" />
    <asp:Button CommandName="btnFind" Text="Find" runat="server" OnClick="btnFind_Click" />    
    <br />
    <br />
    <asp:Button CommandName="btnAdd" Text="Add Player" runat="server" OnClick="btnAddPlayer_Click" />

</asp:Content>
