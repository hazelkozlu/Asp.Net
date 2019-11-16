<%@ Page Title="" Language="C#" MasterPageFile="~/AnaProje.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YapiDenetimProje.Default" %>

<%@ Register Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>PROJE ID</th>
                <th>PROJE ADI</th>
                <th>MEVKİ</th>
                <th>ADA</th>
                <th>PARSEL</th>
                <%--<th>ELKPROADT</th>
                <th>ELKPRODUR</th>
                <th>ELKONYTAR</th>
                <th>TELPROADT</th>
                <th>TELPRODUR</th>
                <th>TELONYTAR</th>
                <th>KONTFORM</th>
                <th>TEDASDOSYASI</th>
                <th>ELEKTRIKCI</th>
                <th>ILETISIM</th>
                <th>ACIKLAMALAR</th>--%>
                <th>DETAY</th>
                <th>SİL</th>
                 <th>GÜNCELLE</th>

            </tr>
        </thead>
        <tbody>

            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>
                    <tr>
                        <td><%#Eval("PROJEID") %></td>
                        <td><%#Eval("PROJEAD") %></td>
                        <td><%#Eval("MEVKI") %></td>
                        <td><%#Eval("ADA") %></td>
                        <td><%#Eval("PARSEL") %></td>
                        <%--<td><%#Eval("ELEKTRIKPROJENUSHA") %></td>
                        <td><%#Eval("ELEKTRIKPROJEDURUM") %></td>
                        <td><%#Eval("ELEKTRIKPROJEONYTAR") %></td>
                        <td><%#Eval("TELEKOMPROJENUSHA") %></td>
                        <td><%#Eval("TELEKOMPROJEDURUM") %></td>
                        <td><%#Eval("TELEKOMPROJEONYTAR") %></td>
                        <td><%#Eval("KONTROLFORMU") %></td>
                        <td><%#Eval("TEDASDOSYASI") %></td>
                        <td><%#Eval("ELEKTRIKCIAD") %></td>
                        <td><%#Eval("ILETISIM") %></td>
                        <td><%#Eval("ACIKLAMALAR") %></td>--%>
                        
                         <td>
                            <asp:HyperLink ID="HyperLink3" NavigateUrl=' <%#"~/ProjeDetay.aspx?PROJEID="+Eval("PROJEID")%>'
                                runat="server" CssClass="btn btn-primary">DETAY</asp:HyperLink>
                        </td>
                       
                         <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl=' <%#"~/ProjeSil.aspx?PROJEID="+Eval("PROJEID")%>'
                                runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink ID="HyperLink2"  NavigateUrl=' <%#"~/ProjeGuncelle.aspx?PROJEID="+Eval("PROJEID")%>'
                                runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>

                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/ProjeEkle.aspx" runat="server" CssClass="btn btn-success">Proje Ekle</asp:HyperLink>
</asp:Content>
