<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính diện tích tma giác vuông</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính diện tích tam giác vuông</h2>

            <label for="cao">Nhập chiều cao: </label>
            <asp:TextBox ID="cao" runat="server"></asp:TextBox>
            <br /><br />

            <label for="huyen">Nhập cạnh hhuyền: </label>
            <asp:TextBox ID="huyen" runat="server"></asp:TextBox>
            <br /><br />


            <asp:Button ID="btnCalculate" runat="server" Text="Run" OnClick="btnCalculate_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

