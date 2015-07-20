﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
        <style>
            @import url(http://fonts.googleapis.com/css?family=Exo:100,200,400);
            @import url(http://fonts.googleapis.com/css?family=Source+Sans+Pro:700,400,300);

            body {
                margin: 0;
                padding: 0;
                background: #fff;
                color: #fff;
                font-family: Arial;
                font-size: 12px;
            }

            .body {
                position: absolute;
                top: -20px;
                left: -20px;
                right: -40px;
                bottom: -40px;
                width: auto;
                height: auto;
                background-image: url("https://www.google.co.in/search?q=optimus+information&espv=2&biw=1366&bih=667&source=lnms&tbm=isch&sa=X&ved=0CAcQ_AUoAmoVChMI2fPhtsLpxgIVA8SOCh3NkQO-#imgrc=lkODTHJKwu2kqM%3A");
                background-size: cover;
                -webkit-filter: blur(5px);
                z-index: 0;
            }

            .grad {
                position: absolute;
                top: -20px;
                left: -20px;
                right: -40px;
                bottom: -40px;
                width: auto;
                height: auto;
                background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(0,0,0,0)), color-stop(100%,rgba(0,0,0,0.65))); /* Chrome,Safari4+ */
                z-index: 1;
                opacity: 0.7;
            }

            .header {
                position: absolute;
                top: calc(50% - 35px);
                left: calc(30% - 255px);
                z-index: 2;
            }

                .header div {
                    float: left;
                    color: #fff;
                    font-family: 'Exo', sans-serif;
                    font-size: 35px;
                    font-weight: 200;
                }

                    .header div span {
                        color: #5379fa !important;
                    }

            .login {
                position: absolute;
                top: calc(50% - 75px);
                left: calc(50% - 50px);
                height: 150px;
                width: 350px;
                padding: 10px;
                z-index: 2;
            }

                .login input[type=text] {
                    width: 250px;
                    height: 30px;
                    background: transparent;
                    border: 1px solid rgba(255,255,255,0.6);
                    border-radius: 2px;
                    color: #fff;
                    font-family: 'Exo', sans-serif;
                    font-size: 16px;
                    font-weight: 400;
                    padding: 4px;
                }

                .login input[type=password] {
                    width: 250px;
                    height: 30px;
                    background: transparent;
                    border: 1px solid rgba(255,255,255,0.6);
                    border-radius: 2px;
                    color: #fff;
                    font-family: 'Exo', sans-serif;
                    font-size: 16px;
                    font-weight: 400;
                    padding: 4px;
                    margin-top: 10px;
                }

            .button {
                width: 260px;
                height: 35px;
                background: #fff;
                border: 1px solid #fff;
                cursor: pointer;
                border-radius: 2px;
                color: #a18d6c;
                font-family: 'Exo', sans-serif;
                font-size: 16px;
                font-weight: 400;
                padding: 6px;
                margin-top: 10px;
            }

            .login input[type=Button1]:hover {
                opacity: 0.8;
            }

            .login input[type=Button1]:active {
                opacity: 0.6;
            }

            .login input[type=text]:focus {
                outline: none;
                border: 1px solid rgba(255,255,255,0.9);
            }

            .login input[type=password]:focus {
                outline: none;
                border: 1px solid rgba(255,255,255,0.9);
            }

            .login input[type=Button1]:focus {
                outline: none;
            }

            ::-webkit-input-placeholder {
                color: rgba(255,255,255,0.6);
            }

            ::-moz-input-placeholder {
                color: rgba(255,255,255,0.6);
            }
        </style>
</head>
<body>
    <form <form id="form1" runat="server">

  <div class="body"></div>
		<div class="grad"></div>
		<div class="header">
			<div><span></span>Welcome to Optimus</span></div>
		</div>
		
		<div class="login">
				 <asp:TextBox ID="username" runat="server" placeholder="username"></asp:TextBox>
				<asp:TextBox ID="password" runat="server" placeholder="password"></asp:TextBox>
            <br />  <br />
				    <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click1" CssClass="button" />
		</div>
   

    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    
    </form>

    </body>
</html>
