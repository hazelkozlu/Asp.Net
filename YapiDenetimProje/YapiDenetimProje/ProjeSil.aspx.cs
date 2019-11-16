using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YapiDenetimProje
{
    public partial class ProjeSil : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {

                    id = Convert.ToInt32(Request.QueryString["PROJEID"].ToString());
                    TxtProjeID.Text = id.ToString();
                    DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
                    TxtProjeAd.Text = dt.ProjeSec(id)[0].PROJEAD;
                    TxtMevki.Text = dt.ProjeSec(id)[0].MEVKI;
                    TxtAda.Text = dt.ProjeSec(id)[0].ADA.ToString();
                    TxtParsel.Text = dt.ProjeSec(id)[0].PARSEL.ToString();
                    TxtElkProNusha.Text = (dt.ProjeSec(id)[0].ELEKTRIKPROJENUSHA).ToString();
                    TxtElkProDurum.Text = dt.ProjeSec(id)[0].ELEKTRIKPROJEDURUM;
                    TxtElkProOnyTar.Text = dt.ProjeSec(id)[0].ELEKTRIKPROJEONYTAR;
                    TxtTelProNusha.Text = dt.ProjeSec(id)[0].TELEKOMPROJENUSHA.ToString();
                    TxtTelProDurum.Text = dt.ProjeSec(id)[0].TELEKOMPROJEDURUM;
                    TxtTelProOnyTar.Text = dt.ProjeSec(id)[0].TELEKOMPROJEONYTAR;
                    TxtKontFormu.Text = dt.ProjeSec(id)[0].KONTROLFORMU;
                    TxtTedasDosya.Text = dt.ProjeSec(id)[0].TEDASDOSYASI;
                    TxtElektrikciAd.Text = dt.ProjeSec(id)[0].ELEKTRIKCIAD;
                    TxtIletisim.Text = dt.ProjeSec(id)[0].ILETISIM;
                    TextArea1.Value = dt.ProjeSec(id)[0].ACIKLAMALAR;

                }
                catch (Exception)
                {
                    TextArea1.Value = "Açıklama Giriniz";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
            dt.ProjeSil(Convert.ToInt32(TxtProjeID.Text));
            Response.Redirect("Default.aspx");
        }

        protected void BtnElkOnyTar_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void BtnTelOnyTar_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TxtElkProOnyTar.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TxtTelProOnyTar.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }
    }
}