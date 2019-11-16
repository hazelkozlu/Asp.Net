using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YapiDenetimProje
{
    public partial class SilinenProjelerDetay : System.Web.UI.Page
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
                    DataSet1TableAdapters.TBL_SILINENLERTableAdapter dt = new DataSet1TableAdapters.TBL_SILINENLERTableAdapter();
                    TxtProjeAd.Text = dt.SilinenProjeSec(id)[0].PROJEAD;
                    TxtMevki.Text = dt.SilinenProjeSec(id)[0].MEVKI;
                    TxtAda.Text = dt.SilinenProjeSec(id)[0].ADA.ToString();
                    TxtParsel.Text = dt.SilinenProjeSec(id)[0].PARSEL.ToString();
                    TxtElkProNusha.Text = (dt.SilinenProjeSec(id)[0].ELEKTRIKPROJENUSHA).ToString();
                    TxtElkProDurum.Text = dt.SilinenProjeSec(id)[0].ELEKTRIKPROJEDURUM;
                    TxtElkProOnyTar.Text = dt.SilinenProjeSec(id)[0].ELEKTRIKPROJEONYTAR;
                    TxtTelProNusha.Text = dt.SilinenProjeSec(id)[0].TELEKOMPROJENUSHA.ToString();
                    TxtTelProDurum.Text = dt.SilinenProjeSec(id)[0].TELEKOMPROJEDURUM;
                    TxtTelProOnyTar.Text = dt.SilinenProjeSec(id)[0].TELEKOMPROJEONYTAR;
                    TxtKontFormu.Text = dt.SilinenProjeSec(id)[0].KONTROLFORMU;
                    TxtTedasDosya.Text = dt.SilinenProjeSec(id)[0].TEDASDOSYASI;
                    TxtElektrikciAd.Text = dt.SilinenProjeSec(id)[0].ELEKTRIKCIAD;
                    TxtIletisim.Text = dt.SilinenProjeSec(id)[0].ILETISIM;
                    TextArea1.Value = dt.SilinenProjeSec(id)[0].ACIKLAMALAR;

                }
                catch (Exception)
                {
                    TextArea1.Value = "Açıklama ";
                }
            }
        }
    }
}