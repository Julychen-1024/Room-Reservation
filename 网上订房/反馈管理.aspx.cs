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
    public partial class 反馈管理 : System.Web.UI.Page
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
            string sql = "SELECT * FROM tb_suggestion";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter ada = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ada.Fill(ds, "tb_suggestion");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sid = TextBox1.Text;
            string sql = "DELETE FROM tb_suggestion WHERE SuggestionID='" + sid + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('删除成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }
    }
}