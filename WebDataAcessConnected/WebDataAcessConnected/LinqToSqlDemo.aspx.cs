using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDataAcessConnected
{
    public partial class LinqToSqlDemo : System.Web.UI.Page
    {
        EmployeeDataClassDataContext db = new EmployeeDataClassDataContext();

        public void ShowGrid()
        {
            var methodEmps = db.EmployeTbls.OrderByDescending(em => em.empName);

            GridView1.DataSource = methodEmps;
            //GridView1.DataSource = emps;
            GridView1.DataBind();
        }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //var emps = from emp in db.EmployeTbls
            //           where emp.empName.StartsWith("S")
            //           orderby emp.empName
            //           select emp;
            if (!IsPostBack)
            {
                ShowGrid();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Sp_searchEmp(Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text));
            txtName.Text = GridView1.SelectedRow.Cells[2].Text;
            TxtSalary.Text = GridView1.SelectedRow.Cells[3].Text;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeTbl emp = new EmployeTbl();
            emp.empName = txtName.Text;
            emp.empSal = Convert.ToSingle(TxtSalary.Text);
            db.GetTable<EmployeTbl>().InsertOnSubmit(emp);
            db.SubmitChanges();
            ShowGrid();
            


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeTbl empTbl = db.EmployeTbls.Single(em => em.empId == Convert.ToInt32(txtId.Text));
            empTbl.empName = txtName.Text;
            empTbl.empSal = Convert.ToSingle(TxtSalary.Text);
            db.SubmitChanges();
            ShowGrid();
                
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeTbl empTbl = db.EmployeTbls.Single(em => em.empId == Convert.ToInt32(txtId.Text));
            db.EmployeTbls.DeleteOnSubmit(empTbl);
            db.SubmitChanges();
            ShowGrid();

        }

        protected void SelectWithSP_Click(object sender, EventArgs e)
        {
            db.Sp_searchEmp(Convert.ToInt32(txtId.Text));
                //txtName.Text=
        }
    }
}