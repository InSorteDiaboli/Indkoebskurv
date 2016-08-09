<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestBruger.aspx.cs" Inherits="Indkoebskurv.TestBruger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_user" runat="server" Text=""> </asp:Label>
            <asp:Button ID="btn_opret" runat="server" Text="Opret" OnClick="btn_opret_Click" />
            <asp:Button ID="btn_slet" runat="server" Text="Slet" OnClick="btn_slet_Click" />
            <asp:Button ID="btn_reload" runat="server" Text="Reload" />
            <asp:Label ID="lbl_name" runat="server" Text=""> </asp:Label>
            <label></label>
        </div>
    </form>
</body>
</html>
