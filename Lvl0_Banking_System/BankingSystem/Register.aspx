<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BankingSystem.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3">
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <div class="mb-3">
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="username" REQUIRED></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <asp:Label ID="lblPassword" runat="server" Text="Password" REQUIRED></asp:Label>
            <div class="mb-3">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Button ID="btnSignup" runat="server" CssClass="btn btn-outline-success" Text="Sign up" OnClick="btnSignup_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
