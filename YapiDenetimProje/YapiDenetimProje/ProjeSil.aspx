<%@ Page Title="" Language="C#" MasterPageFile="~/AnaProje.Master" AutoEventWireup="true" CodeBehind="ProjeSil.aspx.cs" Inherits="YapiDenetimProje.ProjeSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <b>
                    <asp:Label for="TxtProjeID" runat="server" Text="Proje ID"></asp:Label>
                </b>
                <asp:TextBox ID="TxtProjeID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Boş Geçilemez!" ControlToValidate="TxtProjeAd" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtProjeAd" runat="server" Text="Proje Adı"></asp:Label>
                </b>
                <asp:TextBox ID="TxtProjeAd" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş Geçilemez!" ControlToValidate="TxtProjeAd" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtMevki" runat="server" Text="Mevki"></asp:Label>
                </b>
                <asp:TextBox ID="TxtMevki" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtMevki" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtAda" runat="server" Text="Ada"></asp:Label>
                </b>
                <asp:TextBox ID="TxtAda" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtAda" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtParsel" runat="server" Text="Parsel"></asp:Label>
                </b>
                <asp:TextBox ID="TxtParsel" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtParsel" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtElkProNusha" runat="server" Text="Elektirik Proje Nüsha"></asp:Label>
                </b>
                <asp:TextBox ID="TxtElkProNusha" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtElkProNusha" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtElkProDurum" runat="server" Text="Elektirik Proje Durum"></asp:Label>
                </b>
                <asp:TextBox ID="TxtElkProDurum" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtElkProDurum" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtElkProOnyTar" runat="server" Text="Elektirik Proje Onay Tarihi" ></asp:Label>
                </b>
                <br />
                <asp:TextBox ID="TxtElkProOnyTar" runat="server" Enabled="False"></asp:TextBox>
                <asp:Button ID="BtnElkOnyTar" runat="server" Text="Tarih Seç" OnClick="BtnElkOnyTar_Click" />
<%--                <asp:TextBox ID="TxtElkProOnyTar" runat="server" CssClass="form-control" ></asp:TextBox>--%>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız"ControlToValidate="TxtElkProOnyTar" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" Visible="False" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged" BorderWidth="1px" NextPrevFormat="FullMonth">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </div>

            <br />
            <div>
                <b>
                    <asp:Label for="TxtTelProNusha" runat="server" Text="Telekom Proje Nüsha"></asp:Label>
                </b>
                <asp:TextBox ID="TxtTelProNusha" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtTelProNusha" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtTelProDurum" runat="server" Text="Telekom Proje Durum"></asp:Label>
                </b>
                <asp:TextBox ID="TxtTelProDurum" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız"ControlToValidate="TxtTelProDurum" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="Calendar2" runat="server" Text="Telekom Proje Onay Tarihi"></asp:Label>
                </b>
                <br />
                <asp:TextBox ID="TxtTelProOnyTar" runat="server" Enabled="False"> </asp:TextBox>
                <asp:Button ID="BtnTelOnyTar" runat="server" Text="Tarih Seç" OnClick="BtnTelOnyTar_Click" />
                <%--<asp:TextBox ID="TxtTelProOnyTar" runat="server" CssClass="form-control"></asp:TextBox>--%>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtTelProOnyTar" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </div>
            <br />
            <div>
                <b>
                    <asp:Label for="TxtKontFormu" runat="server" Text="Kontrol Formu"></asp:Label>
                </b>
                <asp:TextBox ID="TxtKontFormu" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtKontFormu" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>

            <br />
            <div>
                <b>
                    <asp:Label for="TxtTedasDosya" runat="server" Text="Tedaş Dosyası"></asp:Label>
                </b>
                <asp:TextBox ID="TxtTedasDosya" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtTedasDosya" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>

            <br />
            <div>
                <b>
                    <asp:Label for="TxtElektrikciAd" runat="server" Text="Elektirikçi Adı Soyadı"></asp:Label>
                </b>
                <asp:TextBox ID="TxtElektrikciAd" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtElektrikciAd" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>

            <br />
            <div>
                <b>
                    <asp:Label for="TxtIletisim" runat="server" Text="İletişim"></asp:Label>
                </b>
                <asp:TextBox ID="TxtIletisim" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TxtIletisim" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>

            <br />
            <div>
                <b>
                    <asp:Label for="TextArea1" runat="server" Text="Açıklamalar"></asp:Label>
                </b>
                <textarea id="TextArea1" cols="20" rows="6" class="form-control" runat="server" Enabled="False"></textarea>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="Veri Yoksa  rakam ile 0  yazınız" ControlToValidate="TextArea1" ForeColor="Red"></asp:RequiredFieldValidator>--%>

            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Sil" CssClass="btn btn-danger" OnClick="Button1_Click" /> </>
            <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/Default.aspx" CssClass="btn btn-success">Listeye Geri Dön</asp:HyperLink>

        </div>

    </form>
</asp:Content>
