<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AlaaDamiri.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    </div>
        <asp:GridView ID="GridView1" runat="server" AllowCustomPaging="false" AutoGenerateColumns="false">
            <Columns>
                 <%--<asp:BoundField DataField="ID" HeaderText="ID"  />--%>
                <asp:BoundField DataField="Text" ItemStyle-Width="500px" HeaderText="Text" />
                <asp:BoundField DataField="CreatedAt" ItemStyle-Width="150px" HeaderText="CreatedAt" />
                <asp:BoundField DataField="Type" ItemStyle-Width="20px" HeaderText="Type" />
                <asp:BoundField DataField="RetweetCount" ItemStyle-Width="20px" HeaderText="RetweetCount" />
                <asp:BoundField DataField="FavoriteCount" ItemStyle-Width="20px" HeaderText="FavoriteCount" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
