<%@ Page Language="C#" AutoEventWireup="true"   MasterPageFile="~/Masters/Master.Master"
CodeBehind="Index.aspx.cs" EnableSessionState="True" Inherits="Prod.UI.Web.Pages.Index" %>

<%@ Register Src="../UserControls/ucPageTitle.ascx" TagName="ucTitulo" TagPrefix="uc1" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:ucTitulo ID="ucTitulo1" runat="server"></uc1:ucTitulo>
    <div class="page-content">
    </div>
</asp:Content>