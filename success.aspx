<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="WebAppAssignment.success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-content:center">
            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 116px; top: 15px; position: absolute"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 115px; top: 56px; position: absolute" ></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Batch Name"></asp:Label>
            <asp:Label ID="lblBatch" runat="server" style="z-index: 1; left: 115px; top: 97px; position: absolute" ></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
