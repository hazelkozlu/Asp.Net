using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace YapiDenetimProje
{

    public partial class ProjeEkle : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Baslangic();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                    DataSet1TableAdapters.TBL_ISBILGISITableAdapter dt = new DataSet1TableAdapters.TBL_ISBILGISITableAdapter();
                    dt.ProjeEkle(TxtProjeAd.Text, TxtMevki.Text, Convert.ToInt32(TxtAda.Text), Convert.ToInt32(TxtParsel.Text), Convert.ToInt32(TxtElkProNusha.Text), TxtElkProDurum.Text, Calendar1.SelectedDate.ToString(),
                    Convert.ToInt32(TxtTelProNusha.Text), TxtTelProDurum.Text, Calendar2.SelectedDate.ToString(), TxtKontFormu.Text, TxtTedasDosya.Text, TxtElektrikciAd.Text, TxtIletisim.Text, TextArea1.Value.ToString());
                    Response.Redirect("Default.aspx");



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

        protected void BtnTelOnyTar_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TxtTelProOnyTar.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }
    }
}