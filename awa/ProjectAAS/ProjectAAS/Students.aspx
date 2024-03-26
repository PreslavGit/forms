<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Students.aspx.cs"
    Inherits="ProjectAAS.Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridViewContent" runat="server"
        OnRowCommand="GridViewContent_RowCommand" AutoGenerateColumns="False">
        <Columns>
            <asp:ButtonField ButtonType="Link"
                CommandName="Select"
                HeaderText=""
                Text="Select" />
            <asp:BoundField HeaderText="FNumber" DataField="fnumber"></asp:BoundField>
            <asp:BoundField HeaderText="Specialty" DataField="specialtyname"></asp:BoundField>
            <asp:BoundField HeaderText="FName" DataField="fname"></asp:BoundField>
            <asp:BoundField HeaderText="MName" DataField="mname"></asp:BoundField>
            <asp:BoundField HeaderText="LName" DataField="lname"></asp:BoundField>
            <asp:BoundField HeaderText="Address" DataField="address"></asp:BoundField>
            <asp:BoundField HeaderText="Phone" DataField="phone"></asp:BoundField>
            <asp:BoundField HeaderText="Email" DataField="email"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>