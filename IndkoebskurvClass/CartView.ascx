<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartView.ascx.cs" Inherits="Indkoebskurv.CartView" %>

<asp:Repeater ID="rpt_cartView" runat="server" OnItemCommand="rpt_cartView_ItemCommand">
    <HeaderTemplate>
        <table>
            <thead>
                <th>Navn</th>
                <th>Pris</th>
                <th>Antal</th>
                <th>I alt</th>
                <th></th>
            </thead>
            <tbody>
    </HeaderTemplate>

    <ItemTemplate>
        <tr>
            <td>
                <asp:Image ImageUrl="~/img/logo.png" runat="server" /></td>
            <td><%#Eval ("Name") %></td>
            <td><%#Eval ("Price") %></td>
            <td>
                <asp:Button ID="btn_minus" CommandName="minus" CommandArgument='<%#Eval ("Id") %>' Text="-" runat="server" />
                <%#Eval ("Amount") %>
                <asp:Button ID="btn_plus" CommandName="plus" CommandArgument='<%#Eval ("Id") %>' Text="+" runat="server" />
            </td>
            <td><%#Eval ("TotalPrice") %></td>
            <td>Moms udgør <%#Eval ("Vat") %> kr.</td>
            <td>
                <asp:Button ID="btn_delete" CommandName="slet" CommandArgument='<%#Eval ("Id") %>' Text="Slet" runat="server" /></td>
        </tr>
    </ItemTemplate>

    <FooterTemplate>
        </tbody>
        </table>
    </FooterTemplate>
</asp:Repeater>
