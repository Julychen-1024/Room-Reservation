using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 网上订房
{
    public partial class 房间管理 : System.Web.UI.Page
    {
        public static MySqlConnection CreateConn()
        {
            string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(_conn);
            return conn;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateConn();
            }
            MySqlConnection conn = CreateConn();
            conn.Open();
            string sql = "SELECT * FROM tb_room";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter ada = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ada.Fill(ds, "tb_room");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string rid = TextBox1.Text;
            string rtp = TextBox2.Text;
            string rpc = TextBox3.Text;
            string rca = TextBox4.Text;
            string sql = "insert into tb_room (RoomID,RoomType,Price,Capaticy) values('"
                + rid + "','" + rtp+ "','" + rpc + "','" + rca+ "')";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();

            if (rid == "" || rtp == "" || rpc == "" || rca == "")
            {
                Response.Write("<script language=javascript>alert('添加失败，请填写完整信息！')</script>");
            }
            else
            {

                comm.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('添加成功！');window.location.href=document.URL;</script>");
                //Response.Redirect("FirstPage.aspx");
            }
            conn.Close();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string rid = TextBox1.Text;
            string rtp = TextBox2.Text;
            string rpc = TextBox3.Text;
            string rca = TextBox4.Text;
            string sql = "UPDATE tb_room SET RoomType='"+rtp+"',RoomPrice='"+rpc+ "',Capaticy='"+rca+"' WHERE OrderID='" + rid + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('修改成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string rid = TextBox1.Text;
            string rtp = TextBox2.Text;
            string rpc = TextBox3.Text;
            string rca = TextBox4.Text;
            string sql = "DELETE FROM tb_room WHERE OrderID='" + rid + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('删除成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }
    }
}