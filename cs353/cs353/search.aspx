<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="cs353.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="form-wrapper">
        <input type="text" id="searchRecipe" runat="server" placeholder="Search for..." />
        <input type="submit" value="go" id="submit" runat="server" onServerclick="searchOnRecipe"/>
        Start: <input type="date" id="Date1" runat="server" />
        End:   <input type="date" id="endDate" runat="server" />
    </form>
</body>
</html>
