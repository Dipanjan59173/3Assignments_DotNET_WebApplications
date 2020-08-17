using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebDataAcessConnected
{
    public partial class Connectedobjects : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I047OES;Initial Catalog=tranning;Integrated Security=True");

        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public void Showgrid()
        {
            conn.Open();

             cmd = new SqlCommand("select * from EmployeTbl", conn);
             dr = cmd.ExecuteReader();

             dt = new DataTable(); // empty table

            dt.Load(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();

            dr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Showgrid();
            }
            


            //using (SqlConnection conn = new SqlConnection())
            //{
            // the should be mandatory thing 
            //}
           //while (dr.Read() && dr.HasRows)
            //{
            //    GridView1.DataSource = dr;
            //    DropDownList1.DataSource = dr;
            //    //DropDownList1.SelectedValue = dr[1].ToString();
            //    GridView1.DataBind();

            //    DropDownList1.DataBind();
            //}



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEmpDetails_Click(object sender, EventArgs e)
        { 
            // ===========single & dounle Quotation============ 

            conn.Open();
            cmd = new SqlCommand("insert into EmployeTbl(empName,empSal) values('"+txtEname.Text+"',"+txtEmpSal.Text+")",conn);
            int x = cmd.ExecuteNonQuery();
            if (x <= 0)
            {
                Console.WriteLine("insert Unscessfull");
            }

            conn.Close();
            Showgrid(); //Select query 
        }

        protected void btnUpdateWithPara_Click(object sender, EventArgs e)
        {
            //----------------parameters @--------------
            conn.Open();
            cmd = new SqlCommand("update EmployeTbl set EmpName =@empname, empSal =@empsal Where empId =@empid", conn);

            cmd.Parameters.Add("@empid",SqlDbType.Int).Value=Convert.ToInt32(txtEmpId.Text);

            cmd.Parameters.Add("@empname", SqlDbType.VarChar,20).Value = txtEname.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("Alert(one row update)");
            }

            conn.Close();
            Showgrid(); //Select query 


        }

        protected void btnDeleteWithSp_Click(object sender, EventArgs e)
        {
            //=====================storedprocedure where query we have write in SqlSever========================== 
            conn.Open();
                cmd = new SqlCommand("sp_DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;    // using store storedprocedure is mandatory 
            cmd.Parameters.Add("@empid",SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            Showgrid(); //Select query 

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        { 
            //=====================storedprocedure where query we have write in SqlSever============SEARCH======== 
            conn.Open();
            cmd = new SqlCommand("Sp_searchEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtEname.Text = dr[1].ToString();
                txtEmpSal.Text = dr["empsal"].ToString();

            }
            else
            {
                Label1.Text = "Please Enter corrent Employee ID";

                //txtEname.Text = "EMP DOEST NOT EXISTS ";
                //txtEname.Visible = false;

            }

            conn.Close();
           // Showgrid(); //Select query 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update EmployeTbl set EmpName =@empname, empSal =@empsal Where empId =@empid", conn);

            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);

            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEname.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("Alert(one row insert)");
            }

            conn.Close();
            Showgrid();
        }

       
        protected void btnShow_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsertWithPara_Click(object sender, EventArgs e)
        {
            //----------------parameters @--------------
            conn.Open();
            cmd = new SqlCommand("insert into EmployeTbl(empName ,empSal) values (@empName ,@empSal)", conn);

            // cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);

            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEname.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("Alert(one row update)");
            }

            conn.Close();
            Showgrid(); //Select query 

        }

        protected void btnLnsertSp_Click(object sender, EventArgs e)
        {
            //=====================storedprocedure where query we have write in SqlSever========================== 
            conn.Open();
            cmd = new SqlCommand("sp_InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", txtEname.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Showgrid();
        }

        protected void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            // ===========single & dounle Quotation============ 
            conn.Open();
            cmd = new SqlCommand("Update EmployeTbl set Empname='" + txtEname.Text + "',EmpSal='" + txtEmpSal.Text + "' where EmpId='" + txtEmpId.Text + "'", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            Showgrid();
        }

        protected void btnUpdateSp_Click(object sender, EventArgs e)
        {
            //=====================storedprocedure where query we have write in SqlSever========================== 
            conn.Open();
            cmd = new SqlCommand("sp_UpdateEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.AddWithValue("@EmpName", txtEname.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtEmpSal.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            Showgrid();
        }

        protected void btnDelWithPara_Click(object sender, EventArgs e)
        {
            //----------------parameters @--------------
            conn.Open();
            cmd = new SqlCommand("delete from EmployeTbl  where empId=@EmpId", conn);
            cmd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Showgrid();
        }

        protected void btnDelEmp_Click(object sender, EventArgs e)
        {
            // ===========single & dounle Quotation============ 
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from EmployeTbl   where EmpId='" + txtEmpId.Text + "'", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            Showgrid();
        }
    }
}