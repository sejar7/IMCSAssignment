<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            </div>
            <asp:Label ID="Label1" runat="server" Text="First Name :  "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Last Name :  "></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Batch :"></asp:Label>
                <asp:TextBox ID="txtBatch" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;
            </p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </form>
</body>
</html>
