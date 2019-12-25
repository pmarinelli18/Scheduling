<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Scheduling.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="titleLabel" runat="server" Text="ADD NEW STUDENT"></asp:Label>
        </div>
        <asp:Label ID="firstNameLabel" runat="server" Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="firstNameTB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lastNameLabel" runat="server" Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="lastNameTB" runat="server" OnTextChanged="lastNameTB_TextChanged"></asp:TextBox>
        <br />
        Student Number<br />
        <asp:TextBox ID="studentNumberTB" runat="server"></asp:TextBox>
        <br />
        Date of Birth (YYYY-MM-DD)<br />
        <asp:TextBox ID="dobTB" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="enter" runat="server" OnClick="enter_Click" Text="Enter" />
    </form>
</body>
</html>
