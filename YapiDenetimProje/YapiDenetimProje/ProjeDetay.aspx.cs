using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YapiDenetimProje
{
    public partial class ProjeDetay : System.Web.UI.Page
    {
        void Baslangic()
        {
            TxtProjeAd.Text = "0";
            TxtMevki.Text = "0";
            TxtAda.Text = "0";
            TxtParsel.Text = "0";
            TxtElkProNusha.Text = "0";
            TxtElkProDurum.Text = "0";
            TxtElkProOnyTar.Text = "0";
            TxtTelProNusha.Text = "0";
            TxtTelProDurum.Text = "0";
            TxtTelProOnyTar.Text = "0";
            TxtKontFormu.Text = "0";
            TxtTedasDosya.Text = "0";
            TxtElektrikciAd.Text = "0";
            TxtIletisim.Text = "0";
            TextArea1.Value = "0";
        }
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    Baslangic();
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
                    TextArea1.Value = "Açıklama ";
                }
            }
        }

       
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
            dt.ProjeGuncelle(TxtProjeAd.Text, TxtMevki.Text, Convert.ToInt32(TxtAda.Text), Convert.ToInt32(TxtParsel.Text), Convert.ToInt32(TxtElkProNusha.Text), TxtElkProDurum.Text, Calendar1.SelectedDate.ToString(),
                    Convert.ToInt32(TxtTelProNusha.Text), TxtTelProDurum.Text, Calendar2.SelectedDate.ToString(), TxtKontFormu.Text, TxtTedasDosya.Text, TxtElektrikciAd.Text, TxtIletisim.Text, TextArea1.Value.ToString(), Convert.ToInt32(TxtProjeID.Text));
            Response.Redirect("Default.aspx");
        }

        protected void BtnTelOnyTar_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TxtTelProOnyTar.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }

        protected void BtnElkOnyTar_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TxtElkProOnyTar.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
            dt.ProjeSil(Convert.ToInt32(TxtProjeID.Text));
            Response.Redirect("Default.aspx");
        }
    }
}