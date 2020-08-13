using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace WebAppExplore12_08_2020
{
    
    public partial class WebFromExlpore : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            if (!IsPostBack)
            {


                arr.Add("Select");
                arr.Add("Kolkata");
                arr.Add("Hydrabad");
                arr.Add(" Pune");
                arr.Add("Bangalore");

                List<string> names = new List<string>();
                names.AddRange(new string[] { "Dip", "Subho", "Moni", "Dipanjan", "Samiran" });

                foreach (string s in names)
                {
                    ListBox1.Items.Add(s);
                }
                foreach (string s in arr)
                {
                    RadioButtonList1.Items.Add(s);
                }
                foreach (string s in arr)
                {
                    CheckBoxList1.Items.Add(s);
                }
            }
        }
    }
    
}