<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Match.aspx.cs" Inherits="tpMTM.Match" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.
        
        <asp:GridView ID="gvMatches" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Player1
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPlayer1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Player1.Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Player2
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPlayer2" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Player2.Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Score
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblScore" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Score")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Winner
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblWinner" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Winner.Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </h2>

</asp:Content>
