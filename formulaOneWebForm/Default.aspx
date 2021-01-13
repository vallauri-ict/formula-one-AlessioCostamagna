<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="formulaOneWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList runat="server" ID="cmbTabelle" AutoPostBack="true" OnSelectedIndexChanged="cmbTabelle_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:GridView runat="server" ID="gridView">   </asp:GridView>
    </form>
</body>
</html>
