<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TransferPage.aspx.cs" Inherits="BankingSystem.TransferPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row d-flx justify-content-evenly">
        <div class="col-3">
            <asp:Label ID="lblDestination" runat="server" Text="Write the destination username:"></asp:Label>
            <div class="mb-3">
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Label ID="lblAmount" runat="server" CssClass="p1" Text="Choose the amount:"></asp:Label>
            <div class="mb-3">
                <asp:TextBox ID="txtAmount" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btnAccept" runat="server" CssClass="btn btn-primary" OnClick="btnAccept_Click" Text="Accept" />
            <% if (ConfirmTransfer)
                {%>
            <div class="mb-3">
                <asp:CheckBox ID="chkConfirmTransfer" runat="server" Text="This is the correct amount and transfer destination." />
                <asp:Button ID="btnConfirm" runat="server" CssClass="btn btn-success" Text="Confirm" OnClick="btnConfirm_Click"/>
            </div>
            <% } %>
        </div>
    </div>
</asp:Content>
