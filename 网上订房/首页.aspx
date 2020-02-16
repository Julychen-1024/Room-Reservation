<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="首页.aspx.cs" Inherits="网上订房.首页" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="css/basic.css" />
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
            <ul>
                <li><img src="图片/酒店简介.jpg" /></li>
                <li class="hide"><img src="图片/标准间.jpg"/></li>
                <li class="hide"><img src="图片/大床房.jpg"/></li>
                <li class="hide"><img src="图片/套房.jpg"/></li>
                <li class="hide"><img src="图片/会议室.jpg"/></li>
            </ul>
        </section>
        <aside id="rightAside">
            <article>
                <h1><img src="图片/用户中心.jpg" style="border:0px"/></h1><br />
             <table style="background-image: url('图片/背景.jpg')">
                <tr>
                    <td>账号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td >密码<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td><a href="注册.aspx">没有账号？→点这里注册←</a></td>
                </tr>
            </table>
                <br />
                <h1><img src="图片/管理员.jpg" style="border-style: none; border-color: inherit; border-width: 0px; width: 260px; margin-left: 0px; height: 41px;"/></h1>
                <table style="background-image: url('图片/背景.jpg')">
                <tr>
                    <td>账号<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td >密码<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="登录" OnClick="Button2_Click"/>
                    </td>
                </tr>            
            </table>
            </article>
        </aside>
    </div>
    <div id="showImage">
        <button onclick="closeImage()"><img src="图片/close.png" alt="关闭" width="40" height="40" /></button>
        <img src="" alt="图片暂无" width="100%" id="productImg" />
    </div>
    <p>
        <script>
            //当前图片序号
            var index = 0;
            $(document).ready(function () {
                setInterval("next()", 3000);
            });

            //切换下一张图片
            function next() {
                //当前图片淡出
                $("li:eq(" + index + ")").fadeOut(1500);
                //判断当前图片序号是否为最后一张
                if (index == 4)
                    //如果是最后一张，序号跳转到第一张
                    index = 0;
                else
                    //否则图片序号自增1
                    index++;
                //新图片淡入
                $("li:eq(" + index + ")").fadeIn(1500);
            }

            //产品大图展示
            function showImage(name) {
                //产品放大区域淡入
                $("#showImage").fadeIn(500);
                //指定查看的图片路径
                $("#productImg").attr("src", "images/product/large/" + name + ".jpg");
            }

            //关闭产品大图
            function closeImage() {
                //产品放大区域淡出
                $("#showImage").fadeOut(500);
            }
        </script>
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
