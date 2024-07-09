﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BankingSystem.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
    <div class="row  d-flx justify-content-center">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label ID="lblYour" runat="server" CssClass="h3" Text="Your current balance is:"></asp:Label>
                <asp:Label ID="lblBalance" CssClass="display-1" runat="server" Text="$"></asp:Label>
            </div>
        </div>
    </div>
    <%--        </ContentTemplate>
    </asp:UpdatePanel>--%>
    <div class="row d-flx justify-content-evenly">
        <div class="col-3">
            <div class="mb-3">
                <asp:Button ID="btnWithdraw" runat="server" CssClass="btn btn-success" OnClick="btnWithdraw_Click" Text="Withdraw" AutoPostBack="true" />
                <asp:Button ID="btnDeposit" runat="server" CssClass="btn btn-primary" OnClick="btnDeposit_Click" Text="Deposit" AutoPostBack="true" />
            </div>
        </div>
    </div>
</asp:Content>
