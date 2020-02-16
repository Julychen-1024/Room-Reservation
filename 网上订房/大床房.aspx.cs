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
    public partial class 大床房 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string uid = TextBox1.Text;
            string una = TextBox2.Text;
            string idc = TextBox3.Text;
            string inda = Request.Form["Text1"];
            string tel = TextBox5.Text;
            string pri = TextBox6.Text;
            string sql = "insert into tb_orderinfo (UserID,UserName,IDCard,Tel,RoomType,Price,CheckinDate,OrderState) values('"
                + uid + "','" + una + "','" + idc + "','" + tel + "','" + "大床房" + "','" + pri + "','" + inda + "','" + "预定" + "')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();

            if (uid == "" || una == "" || inda == "" || pri == "" || tel == "" || idc == "")
            {
                Response.Write("<script language=javascript>alert('预定失败，请填写完整信息！')</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('预定成功！')</script>");
                comm.ExecuteNonQuery();
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