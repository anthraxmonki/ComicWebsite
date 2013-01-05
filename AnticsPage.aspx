<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AnticsPage.aspx.cs" Inherits="AnticsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <title>
        Antics
    </title>


    <div>
        Antics Page
    </div>


    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/Test/Antics2008-10-25.jpg"/>
    <br />

    <asp:LinkButton ID="LinkButtonFirst"    runat="server">First</asp:LinkButton>
    &nbsp
    <asp:LinkButton ID="LinkButtonPrevious" runat="server">Previous</asp:LinkButton>
    &nbsp
    <asp:LinkButton ID="LinkButtonRandom"   runat="server">Random</asp:LinkButton>
    &nbsp
    <asp:LinkButton ID="LinkButtonNext"     runat="server">Next</asp:LinkButton>
    &nbsp
    <asp:LinkButton ID="LinkButtonNewest"   runat="server">Newest</asp:LinkButton>

    <br />
    <br />

    <asp:ImageButton ID="ImageButton2" runat="server" />

</asp:Content>

