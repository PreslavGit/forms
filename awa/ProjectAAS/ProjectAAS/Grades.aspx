<%@ Page Title="Grades" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Grades.aspx.cs"
    Inherits="ProjectAAS.Grades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewContent" runat="server"
        OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False">
        <Columns>
            <asp:ButtonField ButtonType="Link"
                CommandName="Select"
                HeaderText=""
                Text="Select" />
            <asp:BoundField HeaderText="Student" DataField="StudentName"></asp:BoundField>
            <asp:BoundField HeaderText="Subject" DataField="SubjectName"></asp:BoundField>
            <asp:BoundField HeaderText="Grade" DataField="grade"></asp:BoundField>
            <asp:BoundField HeaderText="FNumber" DataField="fnumber"></asp:BoundField>
            <asp:BoundField HeaderText="SubjectId" DataField="subjectid"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>