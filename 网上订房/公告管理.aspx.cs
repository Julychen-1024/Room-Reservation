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
    public partial class 公告管理 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static MySqlConnection CreateConn()
        {
            string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(_conn);
            return conn;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string top = TextBox1.Text;
            string con = Request.Form["TextArea1"];
            string date = Request.Form["Text1"];
            string sql = "insert into tb_notice(Title,Content,Date) values('"+top+"','"+con+"','"+date+"')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('提交成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }
    }
}