<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="在线订房.aspx.cs" Inherits="网上订房.在线订房" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="css/在线订房.css" />
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
        <section id="silder">
            <a href="标准房.aspx"><img src="图片/标准间1.jpg" /></a><br />
            <a href="大床房.aspx"><img src="图片/大床房1.jpg" /></a><br />
            <a href="套房.aspx"><img src="图片/套房1.jpg" /></a>
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
