<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BankingSystem.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row  d-flx justify-content-center">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label ID="lblYour" runat="server" CssClass="h3" Text="Your current balance is:"></asp:Label>
                <asp:Label ID="lblBalance" CssClass="display-1" runat="server" Text="$"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
