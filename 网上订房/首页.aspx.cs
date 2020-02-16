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
    public partial class 首页 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string una = TextBox1.Text;
            string upw = TextBox2.Text;
            string sql = "select UserID,UserPwd from tb_users";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            string aa = dr[0].ToString().Trim();
            string bb = dr[1].ToString().Trim();
            if (una == aa || upw == bb)
            {
                Response.Redirect("在线订房.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('账号或密码有问题，请重新输入！')</script>");
            }
            //comm.ExecuteNonQuery();
            conn.Close();
        }
        public static MySqlConnection CreateConn()
        {
            string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(_conn);
            return conn;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = CreateConn();
            string una = TextBox3.Text;
            string upw = TextBox4.Text;
            string sql = "select AdminName,AdminPwd from tb_admin";
            MySqlCommand com= new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader read = com.ExecuteReader();
            read.Read();
            string cc = read[0].ToString().Trim();
            string dd = read[1].ToString().Trim();
            if (una == cc || upw == dd)
            {
                Response.Redirect("后台首页.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('账号或密码有问题，请重新输入！')</script>");
            }
            //comm.ExecuteNonQuery();
            con.Close();
        }
    }
}