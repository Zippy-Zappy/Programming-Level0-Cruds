<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AmountPage.aspx.cs" Inherits="BankingSystem.AmountPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row d-flx justify-content-evenly">
        <div class="col-3">
            <asp:Label ID="lblAmount" runat="server" CssClass="h3" Text="Choose the amount:"></asp:Label>
            <div class="mb-3">
                <asp:TextBox ID="txtAmount" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="btnAccept" runat="server" CssClass="btn btn-primary" OnClick="btnAccept_Click" Text="Accept" />
            </div>
            <% if (ConfirmAmount)
                {%>
                <div class="mb-3">
                    <asp:CheckBox ID="chkConfirmAmount" runat="server" Text="This is the correct amount." />
                    <asp:Button ID="btnConfirm" runat="server" CssClass="btn btn-success" Text="Confirm" OnClick="btnConfirm_Click"/>
                </div>
            <%}%>
        </div>
    </div>
</asp:Content>
