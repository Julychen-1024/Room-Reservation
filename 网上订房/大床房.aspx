<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="大床房.aspx.cs" Inherits="网上订房.大床房" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="css/意见反馈.css" />
    <script src="js/jquery-1.12.3.min.js"></script>
    <script src="js/html5.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <header></header>
        <nav>
            <a href="首页.aspx">/网站首页/</a>
            <a href="酒店简介.html">/酒店简介/</a>
            <a href="在线订房.aspx">/在线订房/</a>
            <a href="意见反馈.aspx">/意见反馈/</a>
            <a href="公告栏.aspx">/公告栏/</a>
        </nav>
    <div id="container">
        <aside id="leftAside">
            <h1><img src="图片/联系.jpg" style="border:0px;" /></h1>
            <div><img src="图片/QQ.jpg"/></div>
            <div><img src="图片/微信.jpg" /></div>
        </aside>
        <section id="silder" style="background-color: #C0C0C0">
            <table style="background-color: #FF9966">
        <tr>
            <td class="auto-style1">账号</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td class="auto-style1"></td></tr>
        <tr>
            <td class="auto-style1">姓名</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td> 
        </tr>
        <tr><td class="auto-style1"></td></tr>
        <tr>
            <td class="auto-style1"> 证件号</td>
            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td class="auto-style1"></td></tr>
         <tr>
            <td class="auto-style1">入住时间</td>
            <td><input id="Text1" type="date" runat ="server" name="Text1" /></td>
        </tr>
        <tr><td class="auto-style1"></td></tr>
         <tr>
            <td class="auto-style1">电话</td>
            <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        </tr>
        <tr><td class="auto-style1"></td></tr>
         <tr>
            <td class="auto-style1">价格</td>
            <td><asp:TextBox ID="TextBox6" runat="server" Text="150" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr><td class="auto-style1"></td></tr>
         <tr>
            <td class="auto-style1"><asp:Button ID="Button1" runat="server" Text="提交" Height="30px" Width="55px" Onclick="Button1_Click"/></td>
        </tr>
    </table>
        <style>
            table{
                position:absolute;
                left:761px;
                text-align:left; 
                 border-style:ridge;
                 font-family:华文楷体; 
                 font-size:24px; 
                 border-width:10px;
                top: 410px;
                width: 319px;
                height: 437px;
            }
        </style>
        </section>
        <aside id="rightAside">
           <img src="图片/欢迎光临.jpg" />
        </aside>
    </div>
    <div id="showImage">
        <button onclick="closeImage()"><img src="图片/close.png" alt="关闭" width="40" height="40" /></button>
        <img src="" alt="图片暂无" width="100%" id="productImg" />
    </div>
    <p>
        
    </p>
    <footer>
        <p>
                江苏省镇江市学府路301号<br />
                地址：江苏省镇江市学府路301号江苏大学
            </p>
    </footer>
    </form>
</body>
</html>
