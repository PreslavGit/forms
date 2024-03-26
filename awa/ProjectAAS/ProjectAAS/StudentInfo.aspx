<%@ Page Title="Student Info" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs"
    Inherits="ProjectAAS.StudentInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    FNumber
    <br />
    <asp:TextBox ID="TextBoxFNumber" runat="server" Enabled="false" />
    <br />

    Specialty
    <br />
    <asp:TextBox ID="TextBoxSpecialtyName" runat="server" Enabled="false" />
    <br />

    FName
    <br />
    <asp:TextBox ID="TextBoxFName" runat="server" />
    <br />

    MName
    <br />
    <asp:TextBox ID="TextBoxMName" runat="server" />
    <br />

    LName
    <br />
    <asp:TextBox ID="TextBoxLName" runat="server" />
    <br />

    Address
    <br />
    <asp:TextBox ID="TextBoxAddress" runat="server" />
    <br />

    Phone
    <br />
    <asp:TextBox ID="TextBoxPhone" runat="server" />
    <br />

    Email
    <br />
    <asp:TextBox ID="TextBoxEmail" runat="server" />
    <br />

    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
</asp:Content>
