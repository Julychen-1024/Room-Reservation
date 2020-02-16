using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网上订房
{
    public partial class 注册 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string uid = TextBox1.Text;
            string una = TextBox2.Text;
            string upwd = TextBox3.Text;
            string sex = TextBox4.Text;
            string tel = TextBox5.Text;
            string idc = TextBox6.Text;
            string sql = "insert into tb_users (UserID,UserName,UserPwd,Sex,Tel,IDCard) values('" + uid + "','" + una + "','" + upwd + "','" + sex + "','" + tel + "','" + idc + "')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            string sql2 = "select UserID from tb_users";
            MySqlCommand comm2 = new MySqlCommand(sql2, conn);
            conn.Open();
            MySqlDataReader dr = comm2.ExecuteReader();
            dr.Read();
            string ui = (String)dr[0].ToString().Trim();
            if (uid == "" || una == "" || upwd == "" || sex == "" || tel == "" || idc == "")
            {
                Response.Write("<script language=javascript>alert('注册失败，请填写完整信息！')</script>");
            }
            else if (uid == ui)
            {
                Response.Write("<script language=javascript>alert('该账号已存在，请重新填写！')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('注册成功！');window.location.href='首页.aspx'</script>");
            }
            conn.Close();
        }
        public static MySqlConnection CreateConn()
        {
            string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(_conn);
            return conn;
        }
    }
}