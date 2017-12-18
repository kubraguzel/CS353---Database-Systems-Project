<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginProfile.aspx.cs" Inherits="cs353.LoginProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>

    <link href="/style_login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div id ="wrapper">
                <div class="link">
                    <h1>Daily Food</h1>
	                <nav>
		                <ul>
			                <a href=".aspx#home">Home</a>
			                <a href=".aspx#login">Login</a>
			       
		                </ul>
	                </nav>
                </div>
                
            
            <article id="login">
            <div class="supporting">
                 <div class="container">
                    <div class="col"><img src="asil.jpg" width = "70px"/>
                      
                        <h2>Login</h2>
                        <label><b>Username</b></label>
                        <input type="text" id="username" placeholder="Enter Username" runat="server" name="uname" required >
                        <label><b>Password</b></label>
                        <input type="password" id="password" placeholder="Enter Password" runat="server"  name="psw" required>
		                <button class="btn"  id="Login" runat="server" onserverclick="login_Click">Log In</button>
                    </div>
                    <div class="col2"><img src="asil.jpg" width = "70px"/>
                        
                        <h2>Sign Up</h2>
                        <label><b>Email</b></label>
                        <input type="text" placeholder="Enter Email" name="email" >

                         <label><b>Username</b></label>
                        <input type="text" placeholder="Enter Username" name="email" >

                        <label><b>Password</b></label>
                        <input type="password" placeholder="Enter Password" name="psw" >

                        <label><b>Repeat Password</b></label>
                        <input type="password" placeholder="Repeat Password" name="psw-repeat" >
                        
                       
		                <a class="btn" href="index.html#three_speakers">Save</a>
                    </div>
                </div>
            </div>
            </article>
        </div>


        
    </form>
</body>
</html>
