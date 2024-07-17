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
    <div class="row d-flx justify-content-evenly">
        <div class="col-6">
            <div class="mb-3">
                <asp:Button ID="btnWithdraw" runat="server" CssClass="btn btn-success" OnClick="btnWithdraw_Click" Text="Withdraw" />
                <asp:Button ID="btnDeposit" runat="server" CssClass="btn btn-primary" OnClick="btnDeposit_Click" Text="Deposit" />
                <asp:Button ID="btnTransfer" runat="server" CssClass="btn btn-primary" OnClick="btnTransfer_Click" Text="Transfer" />
            </div>
            <asp:HiddenField ID="hdnAction" runat="server" />
        </div>
    </div>
</asp:Content>
