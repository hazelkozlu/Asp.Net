using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YapiDenetimProje
{
    public partial class SilinenProjeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_SILINENLERTableAdapter dt = new DataSet1TableAdapters.TBL_SILINENLERTableAdapter();
            Repeater1.DataSource = dt.SilinenListesi();
            Repeater1.DataBind();
        }
    }
}