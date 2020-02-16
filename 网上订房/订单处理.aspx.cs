using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.Configuration;
using System.Data;

namespace 网上订房
{
    public partial class 订单处理 : System.Web.UI.Page
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
            //string uid = TextBox1.Text;
            string sql = "SELECT * FROM tb_orderinfo";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataAdapter ada = new MySqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ada.Fill(ds, "tb_orderinfo");
            GridView1.DataSource = ds;
            //GridView1.DataKeyNames = new string[] { "OrderID" };
            GridView1.DataBind();     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateConn();
            }
            MySqlConnection conn = CreateConn();
            string oid = TextBox1.Text;
            string sql = "UPDATE tb_orderinfo SET OrderState='入住' WHERE OrderID='"+oid+"'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('入住成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CreateConn();
            }
            MySqlConnection conn = CreateConn();
            conn.Open();
            string oid = TextBox1.Text;
            string sql = "DELETE FROM tb_orderinfo WHERE OrderID='"+oid+"'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('删除成功！');window.location.href=document.URL;</script>");
            conn.Close();
        }


        //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GridView1.EditIndex = e.NewEditIndex;
        //    BindData();
        //}
        //protected void GridView1_RowUpdating(object sender,GridViewUpdateEventArgs e)
        //{
        //    string oid = GridView1.DataKeys[e.RowIndex].Values.ToString();
        //    //string uid = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        //    //string una = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
        //    //string idc = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
        //    //string tel = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
        //    //string rmt = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim();
        //    //string pri = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim();
        //    //string cda = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[7].Controls[0])).Text.ToString().Trim();
        //    string ost = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[8].Controls[0])).Text.ToString().Trim();
        //    string sql = "update tb_orderinfo set OrderState='" + ost + "'";
        //    bool update = ExceSQL(sql);
        //    if (update)
        //    {
        //        Response.Write("<script langeage=javascript>alert('修改成功！')</script>");
        //        //设置GridView空间的编辑项的索引为-1，即取消编辑
        //        GridView1.EditIndex = -1;
        //        BindData();  //调用自定义的绑定数据方法
        //    }
        //    else
        //    {
        //        Response.Write("<script langeage=javascript>alert('修改失败！')</script>");
        //    }
        //}
        //bool ExceSQL(string sql)
        //{
        //    string _conn = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //    MySqlConnection conn = new MySqlConnection(_conn);
        //    MySqlCommand comm = new MySqlCommand(sql, conn);
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //        comm.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        //protected void GridView1_RowDeleting(object sender,GridViewDeleteEventArgs e)
        //{
        //    string sql = "delete form tb_orderinfo where OrderID='" + GridView1.DataKeys[e.RowIndex].Values.ToString() + "'";
        //    bool delete = ExceSQL(sql);
        //    if (delete)
        //    {
        //        Response.Write("<script language=javascript>alter('删除成功！')</script>");
        //        BindData();
        //    }
        //    else
        //    {
        //        Response.Write("<script language=javascript>alter('删除失败！')</script>");
        //    }
        //}
    }
}