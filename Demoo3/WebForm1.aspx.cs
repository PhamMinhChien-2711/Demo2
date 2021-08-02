using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demoo3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ThucHanhC#\Demoo3\Demoo3\App_Data\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "select * form LOAIHANG";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataTextField = "Tenloai";
                this.DropDownList1.DataValueField = "Maloai";
                this.DropDownList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}