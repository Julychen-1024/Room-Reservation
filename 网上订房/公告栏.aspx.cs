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
    public partial class 公告栏 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = CreateConn();
            string sqlQuery = "SELECT * FROM tb_notice";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                Label2.Text = (String)dr[2].ToString().Trim();
                Label1.Text = (String)dr[1].ToString().Trim();
                Label3.Text = (String)dr[3].ToString().Trim();
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