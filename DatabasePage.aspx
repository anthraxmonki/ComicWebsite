<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DatabasePage.aspx.cs" Inherits="DatabasePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <h1>
        DatabasePage
    </h1>
    <asp:ImageButton ID="ImageButton1" runat="server"  />


    <asp:Button ID="LinqButton" runat="server" Text="Button" 
    onclick="LinqButton_Click" />
    </asp:Content>

