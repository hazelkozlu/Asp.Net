using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YapiDenetimProje
{
   
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
            DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
            Repeater1.DataSource = dt.ProjeListele();
            Repeater1.DataBind();


        }
    }
}