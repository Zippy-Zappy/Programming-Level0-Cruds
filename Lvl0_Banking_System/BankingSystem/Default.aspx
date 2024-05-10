<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BankingSystem.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label ID="lblBalance" CssClass="h1" runat="server" Text="$"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
