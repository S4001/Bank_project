<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="BankUI.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Transaction </title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body class="container">
    <h1> Accont Details</h1>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="CropsData" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="AccountID" HeaderText="AccountID" />
                    <asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" />
                    <asp:BoundField DataField="AccountsHolderName" HeaderText="AccountsHolderName" />
                    <asp:BoundField DataField="AccountType" HeaderText="AccountType" />
                    <asp:BoundField DataField="CurrentBalance" HeaderText="CurrentBalance" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:Label ID="ErrorMsg" runat="server"></asp:Label>
    </form>
</body>
</html>
