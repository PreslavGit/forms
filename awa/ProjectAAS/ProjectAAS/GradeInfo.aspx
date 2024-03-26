<%@ Page Title="Grade Info" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="GradeInfo.aspx.cs"
    Inherits="ProjectAAS.GradeInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Subject
    <br />
    <asp:TextBox ID="TextBoxSubject" runat="server" Enabled="false" />
    <br />

    Student
    <br />
    <asp:TextBox ID="TextBoxStudent" runat="server" Enabled="false" />
    <br />

    Grade
    <br />
    <asp:TextBox ID="TextBoxGrade" runat="server" />
    <br />

    <br />
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
</asp:Content>
