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
    public partial class 意见反馈 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string topic = Request.Form["TextArea1"];
            string sql = "insert into tb_suggestion (Topic) values('" + topic + "')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            if (topic == "")
            {
                Response.Write("<script language=javascript>alert('不能为空哦！')</script>");
            }
            else
            {
                comm.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('提交成功！感谢您的反馈！')</script>");
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