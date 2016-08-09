<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Indkoebskurv.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Id</td>
                    <td>
                        <asp:TextBox ID="tb_id" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Navn</td>
                    <td>
                        <asp:TextBox ID="tb_name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Pris</td>
                    <td>
                        <asp:TextBox ID="tb_price" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Antal</td>
                    <td>
                        <asp:TextBox ID="tb_amount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Btn_submit" runat="server" Text="Put i kurv" OnClick="Btn_submit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
