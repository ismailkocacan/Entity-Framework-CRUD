<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kullanici.aspx.cs" Inherits="IsmailKocacan.EfOrnek.Presentation.KullaniciView.KullaniciPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        body {
            font-family: Tahoma;
            font-size: 11pt;
            background-color:#E4E4E4;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <table style="width: 200px;" border="0">
            <tr>
                <td>Adı</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Soyadı</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Mail</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="3" align="center">

                    <asp:Button ID="btnSave" runat="server" Text="Kaydet" OnClick="btnSave_Click"/>

                </td>
            </tr>
        </table>
        <asp:Button ID="btnListele" runat="server" Text="Listele" OnClick="btnListele_Click" />
        <asp:DataList ID="dListKullanici" BackColor="WhiteSmoke" BorderStyle="Dotted" BorderWidth="1" BorderColor="Silver" runat="server" Width="100%" OnItemCommand="dListKullanici_ItemCommand">
            <ItemTemplate>
                <asp:Button runat="server" CommandName="DELETE" ID="btnDelete" Text='Sil'></asp:Button>

                <asp:Button runat="server" CommandName="EDIT" ID="btnEdit" Text='Güncelle'></asp:Button>

                <asp:Label runat="server" ID="lblId" Text='<%# Eval("Id") %>' Visible="false"></asp:Label>


                <asp:Label runat="server" ID="lblAd" Text='<%# Eval("Ad") %>' Visible="true"></asp:Label>

                <asp:Label runat="server" ID="lblSoyad" Text='<%# Eval("Soyad") %>' Visible="true"></"></asp:Label>

                <asp:Label runat="server" ID="lblEMailAdres" Text='<%# Eval("EMailAdres") %>' Visible="true"></asp:Label>

                
            </ItemTemplate>
            <SeparatorTemplate>
                <hr style="border: solid 1px #eeeeee;" />
            </SeparatorTemplate>

        </asp:DataList>

        <br />

    </form>
</body>
</html>
