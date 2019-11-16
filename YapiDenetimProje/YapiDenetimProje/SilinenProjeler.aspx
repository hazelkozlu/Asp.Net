<%@ Page Title="" Language="C#" MasterPageFile="~/AnaProje.Master" AutoEventWireup="true" CodeBehind="SilinenProjeler.aspx.cs" Inherits="YapiDenetimProje.SilinenProjeler" %>
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
                            <asp:HyperLink ID="HyperLink3" NavigateUrl=' <%#"~/SilinenProjelerDetay.aspx?PROJEID="+Eval("PROJEID")%>'
                                runat="server" CssClass="btn btn-primary">DETAY</asp:HyperLink>
                        </td>

                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
