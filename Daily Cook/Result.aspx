<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="resultStyle.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="TableHolder" runat="server"></asp:PlaceHolder>
    </form>
    <script>
        $(window).on("load resize ", function () {
            var scrollWidth = $('.tbl-content').width() - $('.tbl-content table').width();
            $('.tbl-header').css({ 'padding-right': scrollWidth });
        }).resize();
    </script>
</body>
</html>
